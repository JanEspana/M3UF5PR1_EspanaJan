using M3UF5PR1_EspanaJan.Models.DTOs;
using M3UF5PR1_EspanaJan.Persistence.DAOs;
using M3UF5PR1_EspanaJan.Persistence.Utils;
using Npgsql;

namespace M3UF5PR1_EspanaJan.Persistence.Mapping
{
    public class RescueDAO : IRescueDAO
    {
        /// <summary>
        /// Inserts a rescue in the database. This is the only method needed in this class.
        /// </summary>
        /// <param name="rescue"></param>
        public void InsertRescue(RescueDTO rescue)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO rescues (rescue_number, rescue_date, animal_id, ga, location) VALUES (@rescue_number, @rescue_date, @animal_id, @ga, @location)", conn))
                {
                    cmd.Parameters.AddWithValue("rescue_number", rescue.RescueNumber);
                    cmd.Parameters.AddWithValue("rescue_date", rescue.RescueDate);
                    cmd.Parameters.AddWithValue("animal_id", rescue.Animal.Id);
                    cmd.Parameters.AddWithValue("ga", rescue.GA);
                    cmd.Parameters.AddWithValue("location", rescue.Location);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Gets all rescues from the database.
        /// </summary>
        /// <returns></returns>
        public List<RescueDTO> GetAllRescue()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM rescues", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<RescueDTO> rescues = new List<RescueDTO>();
                        while (reader.Read())
                        {
                            RescueDTO rescue = new RescueDTO();
                            rescue.Id = reader.GetInt32(0);
                            rescue.RescueNumber = reader.GetString(1);
                            rescue.RescueDate = reader.GetDateTime(2);
                            rescue.Animal = new AnimalDAO().SelectById(reader.GetInt32(3));
                            rescue.GA = reader.GetDouble(4);
                            rescue.Location = reader.GetString(5);
                            rescues.Add(rescue);
                        }
                        return rescues;
                    }
                }
            }
        }
        /// <summary>
        /// Gets a rescue by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public RescueDTO GetRescueById(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM rescues WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        RescueDTO rescue = new RescueDTO();
                        while (reader.Read())
                        {
                            rescue.RescueNumber = reader.GetString(1);
                            rescue.RescueDate = reader.GetDateTime(2);
                            rescue.Animal = new AnimalDAO().SelectById(reader.GetInt32(3));
                            rescue.GA = reader.GetDouble(4);
                            rescue.Location = reader.GetString(5);
                        }
                        return rescue;
                    }
                }
            }
        }
        /// <summary>
        /// Gets all ids from the rescues.
        /// </summary>
        /// <param name="id"></param>"
        /// <returns></returns>
        public List<int> GetAllIds()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM rescues", conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<int> ids = new List<int>();
                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                        }
                        return ids;
                    }
                }
            }
        }
    }
}
