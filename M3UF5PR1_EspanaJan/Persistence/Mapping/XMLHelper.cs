﻿using M3UF5PR1_EspanaJan.Models.DTOs;
using System.Xml.Linq;

namespace M3UF5PR1_EspanaJan.Persistence.Mapping
{
    public class XMLHelper
    {
        /// <summary>
        /// Insert people in the XML file.
        /// </summary>
        /// <param name="person"></param>
        public void InsertPerson(PersonDTO person)
        {
            string path = @"../../../Scores.xml";
            XDocument doc = XDocument.Load(path);
            doc.Root.Add(new XElement("person",
                         new XElement("name", person.Name),
                         new XElement("job", person.Job),
                         new XElement("xp", person.XP),
                         new XElement("rescue", person.RescueNum)));
            doc.Save(path);
        }
        public List<PersonDTO> GetPeople()
        {
            XDocument doc = XDocument.Load(@"../../../Scores.xml");
            List<PersonDTO> people = new List<PersonDTO>();

            foreach (XElement element in doc.Descendants("person"))
            {
                PersonDTO person = new PersonDTO();
                person.Name = element.Element("name").Value;
                person.Job = element.Element("job").Value;
                person.XP = int.Parse(element.Element("xp").Value);
                person.RescueNum = element.Element("rescue").Value;

                people.Add(person);
            }
            return people;
        }
    }
}
