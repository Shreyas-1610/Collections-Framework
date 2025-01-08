using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaInClass
{
    public class Person
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public static List<Person> getAll()
        {
            List<Person> person = new List<Person>()
            {
            new Person { SSN = 1001, Name = "John", Address = "Street", Age = 45 },
            new Person { SSN = 1002, Name = "Emma", Address = "Park", Age = 28 },
            new Person { SSN = 1003, Name = "Daniel", Address = "Lake", Age = 55 },
            new Person { SSN = 1004, Name = "Sophia", Address = "Hill", Age = 34 },
            new Person { SSN = 1005, Name = "James", Address = "City", Age = 61 },
            new Person { SSN = 1006, Name = "Olivia", Address = "Road", Age = 20 },
            new Person { SSN = 1007, Name = "Liam", Address = "Avenue", Age = 39 },
            new Person { SSN = 1008, Name = "Isabella", Address = "Bay", Age = 23 },
            new Person { SSN = 1009, Name = "Mason", Address = "Crest", Age = 18 },
            new Person { SSN = 1010, Name = "Charlotte", Address = "Grove", Age = 72 },
            new Person { SSN = 1011, Name = "Benjamin", Address = "Park", Age = 41 },
            new Person { SSN = 1012, Name = "Amelia", Address = "Glade", Age = 33 },
            new Person { SSN = 1013, Name = "Elijah", Address = "Valley", Age = 29 },
            new Person { SSN = 1014, Name = "Lucas", Address = "Pine", Age = 36 },
            new Person { SSN = 1015, Name = "Lily", Address = "Spring", Age = 62 },
            new Person { SSN = 1016, Name = "Henry", Address = "River", Age = 60 },
            new Person { SSN = 1017, Name = "Jack", Address = "Hill", Age = 47 },
            new Person { SSN = 1018, Name = "Chloe", Address = "Meadow", Age = 22 },
            new Person { SSN = 1019, Name = "Nathan", Address = "Cliff", Age = 38 },
            new Person { SSN = 1020, Name = "Grace", Address = "Plaza", Age = 53 },
            new Person { SSN = 1021, Name = "Ethan", Address = "Ridge", Age = 40 },
            new Person { SSN = 1022, Name = "Harper", Address = "Square", Age = 14 },
            new Person { SSN = 1023, Name = "William", Address = "Brook", Age = 49 },
            new Person { SSN = 1024, Name = "Zoe", Address = "Corner", Age = 71 },
            new Person { SSN = 1025, Name = "Aiden", Address = "Lane", Age = 50 }
            };
            return person;
        }
    }
}

