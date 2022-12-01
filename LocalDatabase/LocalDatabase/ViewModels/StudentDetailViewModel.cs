using LocalDatabase.Models;
using LocalDatabase.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LocalDatabase.ViewModels
{
    public class StudentDetailViewModel : BaseViewModel
    {
        #region Services
        private readonly StudentService dataServiceStudents;
        #endregion

        #region Attributes
        private Student _student;
        private string first_name;
        private string last_name;
        private string fecha_nacimiento;
        private int nota;

        public StudentDetailViewModel(Student student)
        {
            _student = student;
            first_name = student.FirstName;
            last_name = student.LastName;
            fecha_nacimiento = student.FechaNacimiento;
            nota = student.Nota;

        }

        #endregion

        #region Properties

        public string FirstName
        {
            get { return this.first_name; }
            set { SetValue(ref this.first_name, value); }
        }

        public string LastName
        {
            get { return this.last_name; }
            set { SetValue(ref this.last_name, value); }
        }

        public string FechaNacimiento
        {
            get { return this.fecha_nacimiento; }
            set { SetValue(ref this.fecha_nacimiento, value); }
        }

        public int Nota
        {
            get { return this.nota; }
            set { SetValue(ref this.nota, value); }
        }

        string estado = "Aprobado";
        public string Aprobado
        {
            get { return estado; }
            set
            {
                if (nota < 13)
                {
                    estado = "Desaprobado";
                }
            }

        }

        #endregion
    }
}
