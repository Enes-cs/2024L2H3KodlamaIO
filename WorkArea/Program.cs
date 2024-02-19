using WorkArea.Business.Concrete;
using WorkArea.DataAccess.Abstract;
using WorkArea.DataAccess.Concrete.EfDal;
using WorkArea.DataAccess.Concrete.InMermoryDal;
using WorkArea.Entities.Concrete;

namespace WorkArea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region CategoryDal Test
            Console.WriteLine("----------CategoryDal Test----Başladı----------------------------------------------");
            Category category = new Category { CategoryId = 1, CategoryName = "Programlama" };
            Category category2 = new Category { CategoryId = 2, CategoryName = "Dil" };
            Category category3 = new Category { CategoryId = 3, CategoryName = "Tasarım" };
            CategoryDal categoryDal = new CategoryDal();
            categoryDal.Add(category);
            categoryDal.Add(category2);
            categoryDal.Add(category3);
            categoryDal.GetById(1);
            categoryDal.Update(1, "Yazılım Eğitimi");
            categoryDal.GetAll();
            Console.WriteLine("----------------------");
            categoryDal.GetById(1);
            categoryDal.GetById(2);
            categoryDal.GetById(3);
            categoryDal.GetById(4);
            categoryDal.Delete(3);
            categoryDal.GetAll();
            Console.WriteLine("----------CategoryDal Test-------Bitti-------------------------------------------");
            #endregion
            #region CategoryService Test
            Console.WriteLine("----------CategoryService Test----------Başladı----------------------------------------");
            CategoryManager eFcategoryManager = new CategoryManager(categoryDal);
            CategoryManager categoryManager = new CategoryManager(categoryDal);
            categoryManager.Add(new Category { CategoryId = 1, CategoryName = "Programlama" });
            categoryManager.GetAll();
            categoryManager.Update(1, "Yazılım");
            categoryManager.GetByCategoryId(1);
            categoryManager.Delete(1);
            categoryManager.GetAll();
            Console.WriteLine("----------CategoryService Test---------------Bitti-----------------------------------");
            #endregion
            #region InstructorDal Test
            Console.WriteLine("----------InstructorDal Test--------Başladı------------------------------------------");
            Instructor ınstructor = new Instructor { InstructorId = 1, InstructorName = "Engin Demiroğ" };
            Instructor ınstructor2 = new Instructor { InstructorId = 2, InstructorName = "Halit Enes Kayakçı" };
            InstructorDal ınstructorDal = new InstructorDal();
            ınstructorDal.Add(ınstructor);
            ınstructorDal.Add(ınstructor2);
            Console.WriteLine("-----------------------");
            ınstructorDal.GetById(1);
            Console.WriteLine("-----------------------");
            ınstructorDal.Update(2, "H. Enes Kalaycı");
            Console.WriteLine("-----------------------");
            ınstructorDal.GetAll();
            ınstructorDal.Delete(2);
            ınstructorDal.GetAll();
            Console.WriteLine("----------InstructorDal Test---------Bitti-----------------------------------------");
            #endregion
            #region InstructorService Test
                        Console.WriteLine("----------InstructorService Test----------------Başladı----------------------------------");
                        InstructorManager ınstructorManager = new InstructorManager(ınstructorDal);
                        ınstructorManager.Add(ınstructor); ınstructorManager.Add(ınstructor2);
                        ınstructorManager.GetById(2);
                        ınstructorManager.Update(2, "Halit Enes Kalaycı");
                        ınstructorManager.GetAll();
                        ınstructorManager.Delete(2);
                        ınstructorManager.GetAll();
                        Console.WriteLine("----------InstructorService Test------------------Bitti--------------------------------");
                        #endregion
            #region CourseDal Test
            Console.WriteLine("----------CourseDal Test--------------Başladı------------------------------------");
            Course course = new Course { Id = 1, Name = "Programlamaya Giriş için Temel Kurs" };
            Course course1 = new Course { Id = 2, Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)" };
            Course course2 = new Course { Id = 3, Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)" };
            Course course3 = new Course { Id = 4, Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)" };
            Course course4 = new Course { Id = 5, Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA" };
            Course course5 = new Course { Id = 6, Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)" };
            Course course6 = new Course { Id = 7, Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)" };
            CourseDal courseDal = new CourseDal();
            courseDal.Add(course);
            courseDal.Add(course1);
            courseDal.Add(course2);
            courseDal.Add(course3);
            courseDal.Add(course4);
            courseDal.Add(course5);
            courseDal.Add(course6);
            Console.WriteLine("------------------");
            courseDal.GetAll();
            Console.WriteLine("------------------");
            courseDal.Update(1, "Yazılıma Giriş için Temel Kurs ");
            Console.WriteLine("------------------");
            courseDal.GetById(4);
            courseDal.Delete(7);
            courseDal.GetAll();
            Console.WriteLine("----------CourseDal Test---------------Bitti-----------------------------------");
            #endregion
            #region CourseService Test
            Console.WriteLine("----------CourseService Test---------------Başladı-----------------------------------");
            CourseManager courseManager = new CourseManager(courseDal);
            courseManager.Add(course); courseManager.Add(course1); courseManager.Add(course2); courseManager.Add(course3); courseManager.Add(course4); courseManager.Add(course5); courseManager.Add(course6);
            courseManager.GetById(4);
            courseManager.Update(1, "Yazılıma Giriş için Temel Kurs");
            courseManager.Delete(1);
            courseManager.Delete(2);
            courseManager.GetAll();
            Console.WriteLine("----------CourseService Test------------------Bitti--------------------------------");
            #endregion
            

            

            

            Console.ReadLine();

        }
    }
}
