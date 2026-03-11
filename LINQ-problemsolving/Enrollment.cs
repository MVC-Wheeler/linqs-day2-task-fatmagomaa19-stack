using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_problemsolving
{
    internal class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        //public Enrollment(int studentId, int courseId)
        //{
        //    StudentId = studentId;
        //    CourseId = courseId;
        //}
        public override string ToString()
        {
            return $"StudentId : {StudentId},CourseId : {CourseId}";
        }

    }

}

