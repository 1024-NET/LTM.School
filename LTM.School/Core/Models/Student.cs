using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string RealName { get; set; }
        public DateTime EnrollmenDate { get; set; }//入学登记时间
        public ICollection<Enrollment> Enrollments { get; set; }//强制与Enrollment表建立关联关系：一对多

    }
}
