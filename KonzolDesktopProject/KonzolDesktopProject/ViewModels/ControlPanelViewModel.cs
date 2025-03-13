using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KonzolDesktopProject.Models;

namespace KonzolDesktopProject.ViewModels
{
    public class ControlPanelViewModel : ObservableObject
    {
        public ObservableCollection<SchoolClass> SchoolClasses { get; } = new ObservableCollection<SchoolClass>();

        public ControlPanelViewModel()
        {
            SchoolClasses.Add(new SchoolClass { ClassId = "A01", StudentCount = 25 });
            SchoolClasses.Add(new SchoolClass { ClassId = "B01", StudentCount = 20 });
            SchoolClasses.Add(new SchoolClass { ClassId = "C01", StudentCount = 30 });
            SchoolClasses.Add(new SchoolClass { ClassId = "D01", StudentCount = 28 });
            SchoolClasses.Add(new SchoolClass { ClassId = "E01", StudentCount = 22 });
        }
    }
}
