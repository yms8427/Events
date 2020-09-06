using System;
using System.Collections.Generic;

namespace BilgeAdam.Events.Models
{
    public class Child
    {
        public string fullName;
        public DateTime birthDate;
        public Parent father;
        public Parent mother;
        public List<Child> siblings;
    }
}
