using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Abstract
{
    public interface IinstructorDal
    {
        void Add(Instructor instructor);
        void Update(int id, string name);
        List<Instructor> GetAll();
        Instructor GetById(int id);
        void Delete(int id);
    }
}
