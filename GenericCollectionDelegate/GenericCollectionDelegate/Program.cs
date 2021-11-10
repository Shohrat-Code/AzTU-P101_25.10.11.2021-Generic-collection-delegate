using GenericCollectionDelegate.Models;
using GenericCollectionDelegate.Repository;
using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionDelegate
{
    //class Test:Department { }

    public delegate void ShowMethods(string msg);
    public delegate bool IsPassed(Student student);
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = new int[0];

            #region Generics
            //Student<int> stu1 = new Student<int>();
            //stu1.Age = 635;
            //stu1.Sum(15);

            //Student<string> stu2 = new Student<string>();
            //stu2.Age = "yash: 25";
            //stu2.Sum("Test");

            //Service<Employee> EmployeeService = new Service<Employee>();
            //Service<Department> DepartmentService = new Service<Department>();

            //EmployeeService.Create();
            //DepartmentService.Create();

            //Employee employee = new Employee();

            //Student<Test> student = new Student<Test>();
            #endregion

            #region Collections

            //LIST
            //List<byte> ageRange = new List<byte>();
            //ageRange.Add(32);
            //ageRange.Add(65);


            //List<byte> ages = new List<byte>();
            //ages.Add(15);
            //ages.Add(97);
            //ages.Add(185);
            //ages.Add(34);
            //ages.Add(12);

            //for (int i = 0; i < ages.Count; i++)
            //{
            //    Console.WriteLine(ages[i]);
            //}

            //foreach (var item in ages)
            //{
            //    Console.WriteLine(item);
            //}

            //ages.AddRange(ageRange);

            //Console.WriteLine(ages.Contains(95));

            //Console.WriteLine(ages.Exists(e => e > 253));

            //Console.WriteLine(ages.Find(e => e > 56));
            //foreach (var item in ages.FindAll(e => e > 56))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(ages.FindIndex(e => e > 56));
            //ages.Remove(97);

            //ages.RemoveAt(2);
            //ages.RemoveRange(2,2);
            //ages.RemoveAll(e => e > 90);

            //Console.WriteLine(ages.TrueForAll(e => e > 50));

            //ages.ForEach(item => Console.WriteLine(item));


            //Dictionary
            //Dictionary<string, string> countryName = new Dictionary<string, string>();
            //countryName.Add("AR","Azerbaijan Republic");
            //countryName.Add("TR", "Turkish Republic");
            //countryName.Add("UK", "United Kingdom");
            //countryName.Add("US","United State");

            //if (countryName.ContainsKey("scx"))
            //{
            //    Console.WriteLine(countryName["scx"]);
            //}
            //foreach (KeyValuePair<string, string> item in countryName)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //string cName;
            //countryName.TryGetValue("AR", out cName);

            //SortedList LIST
            //SortedList<string, string> sortedCountryName = new SortedList<string, string>();
            //sortedCountryName.Add("UK", "United Kingdom");
            //sortedCountryName.Add("TR", "Turkish Republic");
            //sortedCountryName.Add("AR", "Azerbaijan Republic");
            //sortedCountryName.Add("US", "United State");

            //foreach (var item in sortedCountryName)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //QUEUE and Stack

            //Queue<byte> ages = new Queue<byte>();
            //ages.Enqueue(15);
            //ages.Enqueue(64);
            //ages.Enqueue(29);

            //Console.WriteLine(ages.Dequeue());
            //Console.WriteLine("****************************");
            //foreach (var item in ages)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<byte> ages = new Stack<byte>();
            //ages.Push(15);
            //ages.Push(64);
            //ages.Push(29);

            //Console.WriteLine(ages.Pop());
            //Console.WriteLine("****************************");
            //foreach (var item in ages)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue data = new Queue();

            //data.Enqueue(15);
            //data.Enqueue("Irasim");
            //data.Enqueue(true);

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Delegate
            //ShowMethods showMethods = new ShowMethods(Show);
            //showMethods += Displey;

            //showMethods("Salam");
            //showMethods.Invoke("Salam");

            //IsPassed passed = new IsPassed(IsPassedMethod);
            //passed(student1);

            //List<Student> students = new List<Student>();

            Student student1 = new Student() { Id = 1, Name = "Irasim", Score = 545 };
            //Student student2 = new Student() { Id = 2, Name = "Qasim", Score = 173 };
            //Student student3 = new Student() { Id = 3, Name = "Toofiq", Score = 250 };

            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);

            //PassedStudent(students, IsPassedMethod);

            //Func<int, int, int> funcDelegate = new Func<int, int, int>(Test);
            //Action<string, string> actionDelegate = new Action<string, string>(MethodForAction);
            //actionDelegate.Invoke("msg1", "msg2");

            Predicate<Student> predicateDelegate = new Predicate<Student>(IsPassedMethod);
            Console.WriteLine(predicateDelegate(student1)); ;

            #endregion
        }

        //public static void Show(string message)
        //{
        //    Console.WriteLine($"{message} from Show");
        //}

        //public static void Displey(string message)
        //{
        //    Console.WriteLine($"{message} from Displey");
        //}

        public static void PassedStudent(List<Student> students, IsPassed passed)
        {
            foreach (Student student in students)
            {
                if (passed(student))
                {
                    Console.WriteLine($"{student.Name} qebul olub");
                }
                else
                {
                    Console.WriteLine($"{student.Name} qebul olunmayib");
                }
            }
        }

        public static bool IsPassedMethod(Student student)
        {
            return student.Score > 600;
        }

        //public static int Test(int a, int b)
        //{
        //    return a;
        //}

        public static void MethodForAction(string msg, string msg2)
        {
            Console.WriteLine(msg+" "+msg2);
        }
    }
}
