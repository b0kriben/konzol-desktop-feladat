using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KonzolDesktopProject.Models;
using KonzolDesktopProject.Repos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KonzolDesktopProject.ViewModels
{
    public class StudentViewModel : ObservableObject
    {
        private SchoolClass _selectedClass;
        private Student _selectedStudent;
        private SchoolClass _newClass;
        private bool _isNewClassComboVisible;

        public ObservableCollection<SchoolClass> SchoolClasses { get; } = new ObservableCollection<SchoolClass>();

        public SchoolClass SelectedClass
        {
            get => _selectedClass;
            set
            {
                SetProperty(ref _selectedClass, value);
                LoadStudents();
            }
        }

        public Student SelectedStudent
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
        }

        public SchoolClass NewClass
        {
            get => _newClass;
            set => SetProperty(ref _newClass, value);
        }

        public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();

        public bool IsNewClassComboVisible
        {
            get => _isNewClassComboVisible;
            set => SetProperty(ref _isNewClassComboVisible, value);
        }

        public ICommand ChangeClassCommand { get; }

        public StudentViewModel()
        {
            SchoolClasses.Add(new SchoolClass { ClassId = "A01" });
            SchoolClasses.Add(new SchoolClass { ClassId = "B01" });
            SchoolClasses.Add(new SchoolClass { ClassId = "C01" });

            SchoolClasses[0].Students.Add(new Student { Name = "János" });
            SchoolClasses[0].Students.Add(new Student { Name = "Mária" });

            SchoolClasses[1].Students.Add(new Student { Name = "László" });
            SchoolClasses[1].Students.Add(new Student { Name = "Anna" });

            ChangeClassCommand = new RelayCommand<Student>(ChangeClass);
        }

        private void ChangeClass(Student student)
        {
            if (student != null && NewClass != null)
            {
                SelectedClass.Students.Remove(student);

                NewClass.Students.Add(student);

                LoadStudents();

                IsNewClassComboVisible = false;
            }
            else
            {
                MessageBox.Show("Kérlek válassz egy diákot és egy új osztályt!");
            }
        }

        private void LoadStudents()
        {
            Students.Clear();
            if (SelectedClass != null)
            {
                foreach (var student in SelectedClass.Students)
                {
                    Students.Add(student);
                }
            }
        }
    }

    //ezeket kommentelni
    public class SchoolClass
    {
        public string ClassId { get; set; }
        public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();
        public int Id { get; internal set; }
        public int StudentCount { get; internal set; }
    }

    public class Student
    {
        public string Name { get; set; }
    }
}

