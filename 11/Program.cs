using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{

    internal class Program
    {
        public struct student
        {
            public string SecondName;
            public string Name;
            public int Birthday;
            public string Exam;
            public int Result;

            public student(string SecondName, string Name, int Birthday, string Exam, int Result)
            {
                this.SecondName = SecondName;
                this.Name = Name;
                this.Birthday = Birthday;
                this.Exam = Exam;
                this.Result = Result;
            }

            public void PrintPerson()
            {
                Console.WriteLine($"{SecondName} {Name},{Birthday},{Exam},{Result}");
            }

        }

        static void Task_1()
        {
            List<student> AddStudent(List<student> students)
            {

                student new_student;

                Console.Write("Фамилия: ");
                new_student.SecondName = Console.ReadLine();
                Console.Write("Имя: ");
                new_student.Name = Console.ReadLine();
                Console.Write("День рождения: ");
                new_student.Birthday = int.Parse(Console.ReadLine());
                Console.Write("Предмет: ");
                new_student.Exam = Console.ReadLine();
                Console.Write("Баллы: ");
                new_student.Result = int.Parse(Console.ReadLine());

                students.Add(new_student);
                return students;


            }

            List<student> Init_list(List<student> students)
            {
                return students;
            }

            List<student> RemoveStudent(List<student> students)
            {
                Console.Write("Фамилия: ");
                string second_name = Console.ReadLine();
                Console.Write("Имя: ");
                string name = Console.ReadLine();


                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].SecondName == second_name && students[i].Name == name)
                    {
                        students.RemoveAt(i);
                    }
                }

                return students;
            }

            void PrintStudent(List<student> students)
            {
                Console.WriteLine("Студенты");
                foreach (student i in students)
                {
                    i.PrintPerson();
                }
            }

            string str = "";
            List<student> Students = new List<student>();
            Students = Init_list(Students);
            PrintStudent(Students);
            while (str != "exit")
            {
                Console.Write("Команда: ");
                str = Console.ReadLine();

                if (str.Equals("Новый студент"))
                {
                    Students = AddStudent(Students);
                    Console.Clear();
                    PrintStudent(Students);
                }
                else if (str.Equals("Удалить"))
                {
                    Students = RemoveStudent(Students);
                    Console.Clear();
                    PrintStudent(Students);
                }
                else if (str.Equals("Сортировать"))
                {
                    var Sotred_Students = Students.OrderBy(x => x.Result);
                    Students = Sotred_Students.ToList();
                    Console.Clear();
                    PrintStudent(Students);
                }
            }

        }

        static void Main(string[] args)
        {
            Task_1();
            Console.ReadKey();

        }
    }


}