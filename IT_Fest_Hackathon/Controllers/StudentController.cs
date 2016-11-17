using IT_Fest_Hackathon.Models;
using System.Collections.Generic;
using System.Linq;

namespace IT_Fest_Hackathon.Controllers
{
    class StudentController
    {
        public void addStudent(Student student)
        {
            using(var db = new SchoolContext())
            {
                db.students.Add(student);
                db.SaveChanges();
            }
        }

        public int count()
        {
            using(var db = new SchoolContext())
            {
                return db.students.Count();
            }
        }

        public List<Student> getStudents()
        {
            using(var db = new SchoolContext())
            {
                return db.students.ToList();
            }
        }
    }
}
