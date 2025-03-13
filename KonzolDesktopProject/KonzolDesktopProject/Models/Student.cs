using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace KonzolDesktopProject.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsWoman { get; set; }
        public DateTime BirthDay { get; set; }
        public int SchoolClassId { get; set; }

        public Student(int id, string name, bool isWoman, DateTime birthDay, int schoolClassId)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            Id = id;
            Name = name;
            IsWoman = isWoman;
            BirthDay = birthDay;
            SchoolClassId = schoolClassId;
        }

        public override string ToString()
        {
            return $"{Name}, Born: {BirthDay.ToShortDateString()}, Class ID: {SchoolClassId}";
        }
    }
}
