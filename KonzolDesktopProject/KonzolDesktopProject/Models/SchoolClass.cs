using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopProject.Models
{
    public class SchoolClass
    {
        private int Id { get; set; }
        private string? ClassId { get; set; }

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





































/*public class SchoolClass
{
    public int Id { get; set; }
    public string ClassId { get; set; }

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

 
 
 
 
 
 public class Student
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
        return $"Student: {Name}, Gender: {(IsWoman ? "Female" : "Male")}, Birthday: {BirthDay.ToShortDateString()}";
    }
}

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
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

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

public class SchoolClassViewModel : ObservableObject
{
    private readonly SchoolClassRepo _schoolClassRepo;

    public ObservableCollection<SchoolClass> SchoolClasses { get; } = new ObservableCollection<SchoolClass>();

    public SchoolClassViewModel()
    {
        _schoolClassRepo = new SchoolClassRepo();

        // Példányosítunk néhány osztályt
        var class1 = new SchoolClass(1, "9A");
        var class2 = new SchoolClass(2, "9B");
        var class3 = new SchoolClass(3, "10A");
        var class4 = new SchoolClass(4, "10B");
        var class5 = new SchoolClass(5, "11A");

        _schoolClassRepo.AddClass(class1);
        _schoolClassRepo.AddClass(class2);
        _schoolClassRepo.AddClass(class3);
        _schoolClassRepo.AddClass(class4);
        _schoolClassRepo.AddClass(class5);

        LoadClasses();
    }

    private void LoadClasses()
    {
        var allClasses = _schoolClassRepo.GetAllClasses();
        foreach (var schoolClass in allClasses)
        {
            SchoolClasses.Add(schoolClass);
        }
    }
}

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 <Window x:Class="SchoolApp.SchoolClassView"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        mc:Ignorable="d"
        Title="School Classes" Height="350" Width="525">
    
    <Grid>
        <ListView ItemsSource="{Binding SchoolClasses}">
            <ListView.View>
                <GridView>
                    <GridViewColumn Header="Class ID" DisplayMemberBinding="{Binding ClassId}" Width="200" />
                </GridView>
            </ListView.View>
        </ListView>
    </Grid>
</Window>

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 public partial class SchoolClassView : Window
{
    public SchoolClassView()
    {
        InitializeComponent();
        DataContext = new SchoolClassViewModel();
    }
}
*/