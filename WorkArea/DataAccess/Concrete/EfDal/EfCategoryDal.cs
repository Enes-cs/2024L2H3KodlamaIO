using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.DataAccess.Abstract;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Concrete.EfDal
{
    public class EfCategoryDal : ICategoryDal //Simüle amaçlı eklenmiştir.
    {
        List<Category> _categories;  
        public EfCategoryDal()
        {
            _categories = new List<Category>();
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
