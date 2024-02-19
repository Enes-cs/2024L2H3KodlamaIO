using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Business.Abstract;
using WorkArea.DataAccess.Abstract;
using WorkArea.DataAccess.Concrete.InMermoryDal;
using WorkArea.Entities.Concrete;

namespace WorkArea.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IinstructorDal _instructorDal;
        public InstructorManager(IinstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor ınstructor)
        {
          if (ınstructor.InstructorId != 0)
            {
                _instructorDal.Add(ınstructor);
            }
          else
            {
                Console.WriteLine("ID 0 Olamaz");
            }
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void GetById(int id)
        {
            _instructorDal.GetById(id);
        }

        public void Update(int id, string name)
        {
            _instructorDal.Update(id, name);
        }
    }
}
