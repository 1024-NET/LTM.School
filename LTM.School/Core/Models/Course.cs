using LTM.School.Application.enumsType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public CourseGrade Grade { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }//强制与Enrollment表建立关联关系：一对多
    }
}
