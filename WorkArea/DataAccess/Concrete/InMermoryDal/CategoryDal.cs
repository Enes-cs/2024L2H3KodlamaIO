using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.DataAccess.Abstract;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Concrete.InMermoryDal
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            categories = new List<Category>();
        }


        public void Add(Category category)
        {
            categories.Add(category);
            Console.WriteLine(category.CategoryName + " Adlı Category Eklendi");
        }

        public void Delete(int id)
        {
            Category categoryDelete = GetById(id);

            if (categoryDelete != null)
            {
                categories.Remove(categoryDelete);
                Console.WriteLine(categoryDelete.CategoryName + " Category Silindi.");
            }
            else { Console.WriteLine("Category Bulunamadı."); }
        }

        public List<Category> GetAll()
        {
            Console.WriteLine("İşte Kategori Listesi");
            foreach (Category listele in categories)
            {
                Console.WriteLine(listele.CategoryName);
            }

            return categories;
        }

        public Category GetById(int id)
        {
            Category category = categories.FirstOrDefault(categories => categories.CategoryId == id);
            if (category != null)
            {
                Console.WriteLine("ID'si verilen Kategori: " + category.CategoryName);
            }
            else
            {
                Console.WriteLine("Böyle bir ID mevcut Değil");
            }
            return category;
        }

        public void Update(int id, string name)
        {
            foreach (Category FindId in categories)
            {
                if (FindId.CategoryId == id)
                {
                    Console.WriteLine(FindId.CategoryName + " Adlı Kategorinin Adı Güncelleniyor.");
                    FindId.CategoryName = name;
                    Console.WriteLine(name + " Olarak Güncellendi");
                    return;
                }
            }

            Console.WriteLine("Güncellenemedi");
        }


    }
}
