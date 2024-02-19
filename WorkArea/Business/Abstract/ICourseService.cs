using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.DataAccess.Concrete.InMermoryDal;
using WorkArea.Entities.Concrete;

namespace WorkArea.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Delete(int id);
        void Update(int id,string name);
        List<Course> GetAll();
        void GetById(int id);


    }
}
