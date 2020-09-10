using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            K205 k205 = new K205();
            string userInput;
            int input;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please select on the bellow\n");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Student");
                Console.WriteLine("3. Add Prog");
                Console.WriteLine("4. Show Prog List");
                Console.WriteLine("5. Add Teacher");
                Console.WriteLine("6. Show Teacher");
                Console.WriteLine("7. Exit");
                Console.Write(">>>>>>>>>>~<<<<<<<<<<");
                userInput = Console.ReadLine();
                if(int.TryParse(userInput, out input))
                {
                   switch (input)
                    {
                        case 1:
                            k205.AddStudent();
                            break;
                        case 2:
                            foreach (var stu in k205.StudentList)
                            {
                                Console.WriteLine("Id:{0},Name:{1}", stu.Id, stu.Fullname);
                            }
                            break;
                        case 3:
                            k205.AddProg();
                            break;
                        case 4:
                            foreach (var pro in k205.ProgList)
                            {
                                Console.WriteLine("Id:{0},Name:{1}", pro.Id, pro.Fullname);
                            }
                            break;
                        case 5:
                            k205.AddTeacher();
                            break;
                        case 6:
                            foreach (var teach in k205.TeacherList)
                            {
                                Console.WriteLine("Id:{0},Name:{1}", teach.Id, teach.Fullname);
                            }
                            break;
                        case 7:
                            Console.WriteLine("Exit");
                            break;

                        default:
                            Console.WriteLine("Warning: Please write top number\n");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning: Please write numeric number\n");
                }
            } while (userInput != "5");

            
        }
    }
}
