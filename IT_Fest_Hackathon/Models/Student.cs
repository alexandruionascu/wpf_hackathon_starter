using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Fest_Hackathon.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Class> classes {get; set;}
    }
}
