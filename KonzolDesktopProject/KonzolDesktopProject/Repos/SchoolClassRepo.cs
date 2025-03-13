using KonzolDesktopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace KonzolDesktopProject.Repos
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> schoolClasses = new List<SchoolClass>();

        public void AddClass(SchoolClass schoolClass)
        {
            schoolClasses.Add(schoolClass);
        }

        public void UpdateClassName(int id, string newClassId)
        {
            var schoolClass = schoolClasses.FirstOrDefault(sc => sc.Id == id);
            if (schoolClass != null)
            {
                schoolClass.ClassId = newClassId;
            }
        }

        public List<SchoolClass> GetAllClasses()
        {
            return schoolClasses;
        }
    }
}
