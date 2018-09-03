using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    //登记表，因为一个学生要选多门课程，一个课程有多名学生要选
    //中间表，关联学生和课程表之间的关系
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }   
    }
}
