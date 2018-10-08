using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplicationSession1.Concepts;
namespace TestApplicationSession1
{
    class Program
    {

        /*Will Add All the Subjects*/
        public void AddSubjects()
        {
           
            for (int i = 0; i < ArrSub.Length; i++)
            {
                Console.WriteLine("Enter Subject Name : ");
                ArrSub[i].SubjectName = Console.ReadLine();
                Console.WriteLine("Enter Subject Code : ");
               ArrSub[i].SubjectCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Out of Marks of Subject - {0} : ", ArrSub[i].SubjectName);
                ArrSub[i].OutOfMarks = Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for updating Subject records.");
        }


        /*Will Add Students*/
        public void AddStudents()
        {
            int count = 0;
            for (int i = 0; i < ArrStudents.Length; i++)
            {
                Console.WriteLine("Record Number : {0}", count++);
                Console.WriteLine("Enter Student Name : ");
                ArrStudents[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Student Roll No. : ");
                ArrStudents[i].StudentID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for updating Student records.");
        }

        /*Display All the Subjects*/
        public void DisplySubjects()
        {
            Console.WriteLine("");
            Console.WriteLine("Following is the Subject List : ");
            for (int i = 0; i < ArrSub.Length; i++)
            {
                Console.WriteLine($"Subject Name : {ArrSub[i].SubjectName} - Subject Code : {ArrSub[i].SubjectCode} - Subject Out of Marks : {ArrSub[i].OutOfMarks}");
                Console.WriteLine("");
            }
        }

        /*Display All the Subjects*/
        public void DisplyStudents()
        {
            Console.WriteLine("");
            Console.WriteLine("Following is the Student List:");
            for (int i = 0; i < ArrStudents.Length; i++)
            {
                Console.WriteLine($"Student Roll : {ArrStudents[i].StudentID} - Student Name : {ArrStudents[i].Name}");
                Console.WriteLine("");
            }
        }

        /*Preparing Result for the student*/
        public void PrepareResult()
        {
            Console.WriteLine("");
            Console.WriteLine("Preparing Result for the following : ");
            int count = 0;
            for (int i = 0; i < ArrStudExam.Length; i++)
            {
                Console.WriteLine("Record Number : {0}", count++);
                Console.WriteLine("Enter Student ID : ");
                ArrStudExam[i].StudentID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Subject Code : ");
                ArrStudExam[i].SubjectCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Mark Scored : ");
                ArrStudExam[i].MarkScored = float.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
        }

        /*Display Result*/
        public void DisplayResult()
        {
            int count = 0;
            for (int i = 0; i < ArrStudExam.Length; i = i + 3)
            {
                int TempStudentID = ArrStudExam[i].StudentID;
                foreach (Student temp in ArrStudents)
                {
                    if (temp.StudentID == TempStudentID)
                    {
                        Console.WriteLine($"{temp.Name}");
                        count = i;
                        /*Loop to extract Subject Name for each student*/
                        for (int j = 0; j < 3; j++)
                        {
                            int tempSubject = ArrStudExam[count].SubjectCode;
                            foreach (Subjects tempSub in ArrSub)
                            {
                                if (tempSubject == tempSub.SubjectCode)
                                {
                                    Console.WriteLine($"{tempSub.SubjectName} - Out of Marks : { tempSub.OutOfMarks} - Mark Scored : {ArrStudExam[count].MarkScored}");
                                    break;
                                }
                            }
                            count++;
                        }
                        break;
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
        }
>>>>>>> 14278d2342f8b672871ec58234c439e24a9049d2
    }
}

