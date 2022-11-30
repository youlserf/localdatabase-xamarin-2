using LocalDatabase.DataContext;
using LocalDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocalDatabase.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService() => _context = App.GetContext();

        public List<Student> Get()


        {
            return _context.Students.ToList();
        }

        public Student GetByID(int ID)
        {
            return _context.Students.Where(x => x.StudentId == ID).FirstOrDefault();
        }

        public bool Create(Student item)
        {
            try
            {
                _context.Students.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public void CreateList(List<Student> items)
        {
            _context.Students.AddRange(items);
            _context.SaveChanges();
        }
        public void Update(Student item, int ID)
        {
            var model = GetByID(ID);
            model.FirstName = item.FirstName;
            model.LastName = item.LastName;
            model.FechaNacimiento = item.FechaNacimiento;
            model.Nota = item.Nota;
            model.Aprobado = item.Aprobado;
            _context.SaveChanges();
        }
        public void Delete(int ID)
        {
            var model = GetByID(ID);
            _context.Remove(model);
            _context.SaveChanges();
        }

    }
}
