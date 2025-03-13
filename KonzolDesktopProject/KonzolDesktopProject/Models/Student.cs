using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopProject.Models
{
    public class Student
    { 
        private int Id { get; set; }
        private string Name { get; set; }
        private bool IsWoman { get; set; }
        private DateTime BirthDay { get; set; }
        private int SchoolClassId { get; set; }

        public Student(int id, string name, bool isWoman, DateTime birthDay, int schoolClassId)
        {
            Id = id;
            Name = name;
            IsWoman = isWoman;
            BirthDay = birthDay;
            SchoolClassId = schoolClassId;
        }

        public override string ToString()
        {
            return $"Student: {Name}, Gender: {(IsWoman ? "Female" : "Male")}, Birthday: {BirthDay.ToShortDateString()}";
        }
    }
}
