using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.DataAccess.Abstract;
using WorkArea.Entities.Concrete;

namespace WorkArea.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(int id,string name);
        void Delete(int id);
        List<Category> GetAll();
        Category GetByCategoryId(int id);

    }
}
