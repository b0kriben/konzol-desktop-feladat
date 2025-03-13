using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopProject.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentView;

        private readonly ControlPanelViewModel _controlPanelViewModel;
        private readonly SchoolClassViewModel _schoolClassViewModel;
        private readonly StudentViewModel _studentViewModel;

        public MainViewModel()
        {
            _schoolClassViewModel = new SchoolClassViewModel();
            _studentViewModel = new StudentViewModel();
            CurrentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowControlPanelView()
        {
            CurrentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowSchoolClassView()
        {
            CurrentView = _schoolClassViewModel;
        }

        [RelayCommand]
        private void ShowStudentView()
        {
            CurrentView = _studentViewModel;
        }
    }
}
