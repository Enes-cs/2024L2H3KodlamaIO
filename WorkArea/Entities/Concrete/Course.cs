using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Entities.Abstract;

namespace WorkArea.Entities.Concrete
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }



    }
}
