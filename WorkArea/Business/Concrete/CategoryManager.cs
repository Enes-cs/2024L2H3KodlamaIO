using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Business.Abstract;
using WorkArea.DataAccess.Abstract;
using WorkArea.DataAccess.Concrete.InMermoryDal;
using WorkArea.Entities.Concrete;

namespace WorkArea.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            if (category.CategoryId!=0)
            {
                _categoryDal.Add(category);
            }
            else
            {
                Console.WriteLine("Category ID 0 olamaz");
            }
            

        }

        public void Delete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            
            return _categoryDal.GetAll();
        }

        public Category GetByCategoryId(int id)
        {
            return _categoryDal.GetById(id);
            
        }

        public void Update(int id, string name)
        {
            _categoryDal.Update(id, name);
        }

       
    }
}
