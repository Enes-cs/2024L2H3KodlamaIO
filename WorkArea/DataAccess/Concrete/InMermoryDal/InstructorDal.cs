using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.DataAccess.Abstract;
using WorkArea.Entities.Concrete;

namespace WorkArea.DataAccess.Concrete.InMermoryDal
{
    public class InstructorDal : IinstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>();
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
            Console.WriteLine(instructor.InstructorName + " Adlı Eğitmen Eklendi.");
        }

        public void Delete(int id)
        {
            Instructor instructorDelete = GetById(id);

            
                        

            if (instructorDelete != null)
            {
                instructors.Remove(instructorDelete);
                Console.WriteLine("Eğitmen Silindi");
            }
            else { Console.WriteLine("Silinemedi"); }
        }

        public List<Instructor> GetAll()
        {
            foreach (Instructor instructor in instructors)
            {
                Console.WriteLine(instructor.InstructorName);
            }
            return instructors;
        }

        public Instructor GetById(int id)
        {
            var instructor = instructors.FirstOrDefault(i => i.InstructorId == id);
            if (instructors != null)
            {
                Console.WriteLine("ID'si verilen eğitmen: "+instructor.InstructorName);
            }
            else
            {
                Console.WriteLine("Böyle bir ID mevcut Değil");
            }
            return instructor;
            
        }

        public void Update(int id, string name)
        {
            foreach (Instructor instructor in instructors)
            {

                if (instructor.InstructorId == id)
                {
                    instructor.InstructorName = name;
                    Console.WriteLine(id + " Numaralı Id'ye Sahip Instructor " + name + "  Olarak Güncellendi");
                    return;
                }

            }
            Console.WriteLine("Güncellenemedi");

        }
    }

    
}
