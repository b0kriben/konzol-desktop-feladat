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
using System.Windows.Input;

namespace KonzolDesktopProject.ViewModels
{
    public class SchoolClassViewModel : ObservableObject
    {
        private SchoolClass _selectedClass;

        public ObservableCollection<SchoolClass> SchoolClasses { get; } = new ObservableCollection<SchoolClass>();

        public SchoolClass SelectedClass
        {
            get => _selectedClass;
            set => SetProperty(ref _selectedClass, value);
        }

        public ICommand SaveClassCommand { get; }

        public SchoolClassViewModel()
        {
            SchoolClasses.Add(new SchoolClass { Id = 1, ClassId = "A01" });
            SchoolClasses.Add(new SchoolClass { Id = 2, ClassId = "B01" });
            SchoolClasses.Add(new SchoolClass { Id = 3, ClassId = "C01" });

            SaveClassCommand = new RelayCommand<SchoolClass>(SaveClass);
        }

        private void SaveClass(SchoolClass schoolClass)
        {
            System.Diagnostics.Debug.WriteLine($"Osztály mentése: {schoolClass.ClassId}");
        }
    }
}
