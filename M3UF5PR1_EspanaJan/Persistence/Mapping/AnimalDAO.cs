using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using M3UF5PR1_EspanaJan.Models.DTOs;
using M3UF5PR1_EspanaJan.Persistence.Utils;

namespace M3UF5PR1_EspanaJan.Persistence.Mapping
{
    public class AnimalDAO
    {
        /// <summary>
        /// Insert an animal in the database
        /// </summary>
        /// <param name="animal"></param>
        public void InsertAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO animals (name, superfamily, species, weight) VALUES (@name, @superfamily, @species, @weight)", conn))
                {
                    cmd.Parameters.AddWithValue("name", animal.Name);
                    cmd.Parameters.AddWithValue("superfamily", animal.Superfamily);
                    cmd.Parameters.AddWithValue("species", animal.Species);
                    cmd.Parameters.AddWithValue("weight", animal.Weight);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Update an animal in the database
        /// </summary>
        /// <param name="animal"></param>
        public void UpdateAnimal(AnimalDTO animal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE animals SET name = @name, superfamily = @superfamily, species = @species, weight = @weight WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("name", animal.Name);
                    cmd.Parameters.AddWithValue("superfamily", animal.Superfamily);
                    cmd.Parameters.AddWithValue("species", animal.Species);
                    cmd.Parameters.AddWithValue("weight", animal.Weight);
                    cmd.Parameters.AddWithValue("id", animal.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Delete an animal from the database
        /// </summary>
        /// <param name="animal"></param>
        public void DeleteAnimalById(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM animals WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Picks a random animal from the database. It's used for the rescues.
        /// </summary>
        /// <returns></returns>
        public AnimalDTO PickRandomAnimal()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM animals ORDER BY RANDOM() LIMIT 1", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AnimalDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Superfamily = reader.GetString(2),
                                Species = reader.GetString(3),
                                Weight = reader.GetDouble(4)
                            };
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Selects an animal by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AnimalDTO SelectById(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM animals WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AnimalDTO
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Superfamily = reader.GetString(2),
                                Species = reader.GetString(3),
                                Weight = reader.GetDouble(4)
                            };
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Gets the next id for the animal. Not the next in the table, but the next in the sequence.
        /// If a row is deleted, the id is not reused.
        /// Returns 1 if the sequence is empty.
        /// </summary>
        /// <returns></returns>
        public int NextId()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                //check the next number in the sequence
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT last_value FROM animal_id_seq", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0) + 1;
                        }
                    }
                }
            }
            return 1;
        }
        /// <summary>
        /// Used to get all the ids of the animals in the database
        /// It's purpose is to fill the ID comboboxes with all the existing ids
        /// </summary>
        /// <returns></returns>
        public List<int> GetAllIds()
        {
            List<int> ids = new List<int>();
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM animals", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return ids;
        }
    }
}
