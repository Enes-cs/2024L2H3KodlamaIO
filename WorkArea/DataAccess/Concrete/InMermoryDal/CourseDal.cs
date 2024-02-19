using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.DataAccess.Abstract;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Concrete.InMermoryDal
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>();
        }
        public void Add(Course course)
        {
            _courses.Add(course);
            Console.WriteLine(course.Name + " Adlı Kurs Eklendi");
        }

        public void Delete(int id)
        {
            Course courseDelete = GetById(id);
            
            if (courseDelete != null)
            {
                _courses.Remove(courseDelete);
                Console.WriteLine("Kurs Silindi.");
            }
            else { Console.WriteLine("Kurs Silinemedi"); }
        }

        public List<Course> GetAll()
        {
            Console.WriteLine("İşte Kurs Listesi");
            foreach (var course in _courses)
            {
                Console.WriteLine(course.Name);
            }
            return _courses;
        }

        public Course GetById(int id)
        {
            var course = _courses.FirstOrDefault(_courses => _courses.Id == id);
            if (course != null)
            {
                Console.WriteLine("ID'si verilen Kurs: " + course.Name);
            }
            else
            {
                Console.WriteLine("Böyle bir ID mevcut Değil");
            }

            return course;
        }

        public void Update(int id, string name)
        {
            foreach (var course in _courses)
            {
                if (course.Id == id)
                {
                    course.Name = name;
                    Console.WriteLine("Kurs Adı " + course.Name + "Olarak Güncellendi");
                    return;
                }

            }
            Console.WriteLine("Güncellenemedi");

        }
    }
}
