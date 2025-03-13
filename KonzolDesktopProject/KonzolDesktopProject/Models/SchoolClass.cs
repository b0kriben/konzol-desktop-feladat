using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopProject.Models
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string ClassId { get; set; }
        public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();
        public int StudentCount { get; internal set; }

        public SchoolClass(int id, string classId)
        {
            if (string.IsNullOrEmpty(classId))
            {
                throw new ArgumentException("ClassId cannot be null or empty.");
            }

            Id = id;
            ClassId = classId;
        }

        public override string ToString()
        {
            return $"Class ID: {ClassId}";
        }
    }
}


