using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Update(int id,string name);
        List<Category> GetAll();
        Category GetById(int id);
        void Delete(int id);
    }
}
