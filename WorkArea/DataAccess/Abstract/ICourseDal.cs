using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Update(int id,string name);
        List<Course> GetAll();
        Course GetById(int id);
        void Delete(int id);
    }
}
