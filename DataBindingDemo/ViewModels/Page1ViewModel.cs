using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingDemo
{
    public class Page1ViewModel
    {
        public List<Person> People { get; set; }

        public List<School> Schools { get; set; }

        public Page1ViewModel()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = "Hugo", LastName = "Torrico" });
            people.Add(new Person { FirstName = "Ivan", LastName = "Espinosa" });
            people.Add(new Person { FirstName = "Carlos", LastName = "Arredondo" });
            people.Add(new Person { FirstName = "Fernando", LastName = "Valmaceda" });
            people.Add(new Person { FirstName = "Alberto", LastName = "Peña" });
            People = people;

            List<School> schools = new List<School>();
            schools.Add(new School { Name = "Santa Anita" });
            schools.Add(new School { Name = "San Pedro" });
            schools.Add(new School { Name = "Gran Unidad Escolar" });
            Schools= schools;
        }
    }
}
