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
    }
}
