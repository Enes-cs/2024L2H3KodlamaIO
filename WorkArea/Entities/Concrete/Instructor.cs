using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkArea.Entities.Abstract;

namespace WorkArea.Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int  InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorDescription { get; set; }
    }
}
