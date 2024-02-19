using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Business.Abstract;
using WorkArea.DataAccess.Abstract;
using WorkArea.DataAccess.Concrete.InMermoryDal;
using WorkArea.Entities.Abstract;
using WorkArea.Entities.Concrete;

namespace WorkArea.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            if (course.Id!=0)
            {
                _courseDal.Add(course);
            }
            else
            {
                Console.WriteLine("Id 0 Olamaz");
            }
            
        }

        public void Delete(int id)
        {
            if (id!=1)
            {
                _courseDal.Delete(id);
            }
            else
            {
                Console.WriteLine("1 Numaralı kurs Silinemez");
            }
            
        }

        public List<Course> GetAll()
        {
            
            return _courseDal.GetAll();
        }

        public void GetById(int id)
        {
            _courseDal.GetById(id);
        }

        public void Update(int id, string name)
        {
            _courseDal.Update(id, name);
        }
    }
}
