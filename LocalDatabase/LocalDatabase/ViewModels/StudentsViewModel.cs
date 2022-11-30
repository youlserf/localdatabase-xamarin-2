using LocalDatabase.Models;
using LocalDatabase.Services;
using LocalDatabase.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace LocalDatabase.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
        #region Services        
        private readonly StudentService dataServiceStudents;
        #endregion Services

        #region Attributes

        private ObservableCollection<Student> students;

        #endregion Attributes

        #region Properties


        public ObservableCollection<Student> Students
        {
            get { return this.students; }
            set { SetValue(ref this.students, value); }
        }




        #endregion Properties

        #region Command

        public ICommand NeWStudentCommand
        {
            get
            {
                return new Command(NeWStudent);
            }
        }

        public ICommand LoadStudentsCommand
        {
            get
            {
                return new Command(LoadStudents);
            }
        }
        #endregion

        #region Constructor
        public StudentsViewModel()
        {
            this.dataServiceStudents = new StudentService();

            this.CreateStudents();


            this.LoadStudents();


        }
        #endregion Constructor



        #region Methods

        private void NeWStudent()
        {
            Application.Current.MainPage.Navigation.PushAsync(new StudentPage());



        }
        private void LoadStudents()
        {
            var studentsDB = this.dataServiceStudents.Get();
            this.Students = new ObservableCollection<Student>(studentsDB);
        }

        private void CreateStudents()
        {

            var students = new List<Student>()
            {
                new Student
            {
                FirstName = "Youlserf",
                LastName = "Cardenas",
                FechaNacimiento = "31/05/0022",
                Nota = 20,
                Aprobado = "Aprobado"
            },
                new Student
            {
                FirstName = "Ximena",
                LastName = "Rojas",
                FechaNacimiento = "31/05/0022",
                Nota = 15,
                Aprobado = "Aprobado"
            },
            };

            this.dataServiceStudents.CreateList(students);
        }
        #endregion Methods 
    }
}

