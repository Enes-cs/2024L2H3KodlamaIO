using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Entities.Concrete;

namespace WorkArea.Business.Abstract
{
    public interface IInstructorService
    {
        void Add(Instructor ınstructor);
        void Update(int id,string name);
        void Delete(int id);
        void GetById(int id);
        List<Instructor> GetAll();
    }
}
