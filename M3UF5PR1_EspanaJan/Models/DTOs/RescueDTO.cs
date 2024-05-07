using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3UF5PR1_EspanaJan.Models.DTOs
{
    public class RescueDTO
    {
        public int Id { get; set; }
        public string RescueNumber { get; set; }
        public DateTime RescueDate { get; set; }
        public AnimalDTO Animal { get; set; }
        public double GA { get; set; }
        public string Location { get; set; }
        
        /// <summary>
        /// Generates a rescue randomly
        /// </summary>
        /// <param name="animal"></param>
        public void GenerateRescue(AnimalDTO animal)
        {
            Random random = new Random();
            List<string> locations = new List<string> { "America", "Europe", "Asia", "Africa", "Oceania" };

            RescueNumber = "RES" + random.Next(100, 1000);
            DateTime date = new DateTime(random.Next(2010, 2021), random.Next(1, 13), random.Next(1, 29));
            RescueDate = date;
            Animal = animal;
            GA = random.Next(0, 101);
            Location = locations[random.Next(0, locations.Count)];
        }
        /// <summary>
        /// Calculates GA
        /// </summary>
        /// <param name="ga"></param>
        /// <param name="cram"></param>
        /// <returns></returns>
        public double CalculateGA(AnimalDTO animal, double ga, bool cram)
        {
            int x = 0;

            if (animal.Superfamily == "Sea bird")
            {
                x = 15;
                return 2 * ga + 3 - ((ga - 20) * 2) - x;
            }
            else if (animal.Superfamily == "Sea turtle")
            {
                if (cram) x = 5;
                return (ga - x) / 5;
            }
            else
            {
                if (cram) x = 50;
                return ga - (ga / 5) - x;
            }
        }
    }
}
