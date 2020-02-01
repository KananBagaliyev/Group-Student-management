using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Kanan", "Bagaliyev","P507");
            Student s2 = new Student("Farid", "Aliyev", "P507");
            Student s3 = new Student("Mubariz", "Memmedzade", "P507");
            

            Group list = new Group();
            list.append(s1);
            list.append(s2);
            list.append(s3);
            

            list.find(2);



        }
    }
    class Group {
        protected string GroupName;
        private Student[] arrStudent;
        public Group()
        {
            arrStudent = new Student[0];



        }


        public void append(Student s) {

            Array.Resize(ref arrStudent, arrStudent.Length + 1);
            arrStudent[arrStudent.Length - 1] = s;
            Console.WriteLine("Done");
        }

        

        public void find(int ID) {
            foreach (var item in arrStudent) {
                if (ID == item._id) {
                    Console.WriteLine(item);
                }
            }
            
        }

       


    }

    class Student:Group {

        private static int ID;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int _id { get; }

        public Student()
        {
            ID++;
            _id = ID;
        }

        public Student(string name, string surname,string groupname):this()
        {
            Name = name;
            Surname = surname;
            GroupName = groupname;
        }
        public override string ToString()
        {
            return $" ID:{_id} Name:{Name} Surname:{Surname} Group ID:{GroupName}";
        }

    }
}
