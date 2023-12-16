using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Xml.Linq;

namespace Day1andDat2
{
    internal class Program
	{
        static void Main(string[] args)
        {
			#region Assignment
            //1- Design Student Class that contain Info(ID, Name)
                //- Create array of student of size 5
                //- Fill array with 5 student object
                //-Use Array.Sort() Function to sort Array
                //-Add new object in student array(item number 6)
                //-Handel Exception that appear when adding the last item
            //2 - Desgin GList Class that work as list in C# with add function (class accept any type and according type function detect type)
            //Ex

            //	 GList<int> IntList = new GList<int>();
            //			IntList.Add(10);

            //3 - Design class Employee & Trainee
            //     1. Design an interface IPayable that contains:
            //-        Salary Property
            //-       ShowPayment() that display the salary
            //    2.Make Employee & Trainee implement IPayable

            //    3.Try to implement IComparer interface to class Trainee
            //4- Create TwoItemOperation Class that is Generic Class that contain(Sum(), Sub(), Div()) for any Type
            //5-create custom exception for Trainee member(Trainee Salary < 3000)

			#endregion

		// Student Class
		    #region Point 1
			Student[] students = new Student[5];
            students[0] = new Student(12, "Nader");
            students[1] = new Student(11, "Aya");
            students[2] = new Student(19, "Ali");
            students[3] = new Student(9, "Mohamed");
            students[4] = new Student(8, "Omar");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");

            Array.Sort(students);

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            try
            {
                students[6] = new Student(30, "Mona");
            }
            catch (IndexOutOfRangeException Exx)
            {

                Console.WriteLine("The Index of student must be in size array");
            }


            #endregion




            // GList
            #region Point 2
            GList<int> gList = new GList<int>(3);
            gList.Add(1);
            gList.Add(2);
            gList.Add(3);

            GList<float> gList1 = new GList<float>(4);
            gList1.Add(5);
            gList1.Add(6);
            gList1.Add(7);
            gList1.Add(8);


            #endregion




            // Employee and Trainee 
            #region Point 3 and 5


            try
            {
                Employee employee = new Employee();
                employee.Salary = 3000;
                Console.WriteLine(employee.Salary);
            }
            catch (TraineeExcepation Exx)
            {
                Console.WriteLine(Exx.Message);
            }

            try
            {
                Trainee trainee = new Trainee(2500);
            }
            catch (TraineeExcepation Exmessage)
            {
                Console.WriteLine(Exmessage.Message);
            }



            #endregion




            // Sum , Sub , Div
            #region Point 4
            TwoItemOperation<int> twoItemOperation = new TwoItemOperation<int>(10, 15);
            Console.WriteLine("Sum = " + twoItemOperation.Sum(14, 19));
            Console.WriteLine("Sub = " + twoItemOperation.Sub(50, 19));
            Console.WriteLine("Div = " + twoItemOperation.Div(200, 20));
            Console.WriteLine("=================");
            TwoItemOperation<float> twoItemOperation1 = new TwoItemOperation<float>(17, 16);
            Console.WriteLine("Sum = " + twoItemOperation1.Sum(14.5f, 19.4f));
            Console.WriteLine("Sub = " + twoItemOperation1.Sub(320.5f, 60.7f));
            Console.WriteLine("Div = " + twoItemOperation1.Div(100.5f, 10.5f));
            #endregion


            #region Point 2 in Day 2
            PostgraduateList studentGraduate = new PostgraduateList(5);
            studentGraduate[0] = new Student(15, "Nader");
            studentGraduate[1] = new Student(10, "Aya");
            studentGraduate[2] = new Student(18, "Mona");
            foreach (var item in studentGraduate)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadKey();
        }
    }
}