using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_LinqGroupJoin
{
    internal class Student
    {
        public int StudentId { get; set; } //Öğrencinin benzersiz kimliği

        public string StudentName { get; set; } //Öğrencinin adı

        public int ClassId { get; set; } //Öğrencinin ait olduğu sınıfın kimliği
    }
}
