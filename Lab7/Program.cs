using System;
using System.Linq;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t1)Связь 1:М от Отдел к Сотрудник");
            Console.WriteLine("\t1.1. Список всех сотрудников и отделов, отсортированный по отделам");
            foreach (var d in Data.Departments)
            {
                //Перебор (укороченный синтаксис цикла) по каждому сотруднику
                var q1 = from x in Data.Workers
                         where (d.ID == x.DepartmentID)
                         select x;
                //Проверка на соответствие сотрудника его отделу (вывод типа: отдел - сотрудники)
                Console.WriteLine(d);
                foreach (var x in q1) Console.WriteLine("  " + x); 
            }

            Console.WriteLine("\n\t1.2. Список всех сотрудников, у которых фамилия начинается с буквы А");
            string lit = "А";
            var q2 = from x in Data.Workers
                     where (x.Surname.Substring(0, 1) == lit)
                     select x;
            foreach (var x in q2) Console.WriteLine(x);
            if (q2.Count() == 0)
            {
                Console.WriteLine("Такие сотрудники отсутствуют");
            }

            Console.WriteLine("\n\t1.3. Cписок всех отделов и количество сотрудников в каждом отделе");
            foreach (var x in Data.Departments)
            {
                int num = Data.Workers.Count(y => y.DepartmentID == x.ID);
                Console.WriteLine(x + "; Количество: " + num);
            }

            Console.WriteLine("\n\t1.4. Cписок отделов, в которых у всех сотрудников фамилия начинается с буквы А");
            var q3 = from x in Data.Departments
                     where (Data.Workers.Count(y => y.Surname.Substring(0, 1) == "А" && y.DepartmentID == x.ID) == 
                     Data.Workers.Count(y => y.DepartmentID == x.ID))
                     select x;
            foreach (var x in q3) Console.WriteLine(x);
            if (q3.Count() == 0)
            {
                Console.WriteLine("Такие отделы отсутствуют");
            }

            Console.WriteLine("\n\t1.5. Cписок отделов, в которых хотя бы у одного сотрудника фамилия начинается с буквы А");
            var q4 = from x in Data.Departments
                     where (Data.Workers.Count(y => y.Surname.Substring(0, 1) == "А" && y.DepartmentID == x.ID) > 0)
                     select x;
            foreach (var x in q4) Console.WriteLine(x);
            if (q4.Count() == 0)
            {
                Console.WriteLine("Такие отделы отсутствуют");
            }


            Console.WriteLine("\n\t\t2)Связь М:М от Отдел к Сотрудник");
            Console.WriteLine("\t2.1. Cписок всех отделов и список сотрудников в каждом отделе");
            foreach (var x in Data.Departments)
            {
                var q5 = from y in Data.DepartmentWorkers
                         where (y.DepartmentID == x.ID)
                         select y;
                var q6 = from y in Data.Workers
                         from z in q5
                         where (z.WorkerID == y.ID)
                         select y;
                Console.WriteLine(x);
                foreach (var y in q6) Console.WriteLine("  ID: " + y.ID + "; Фамилия: " + y.Surname);
            }

            Console.WriteLine("\n\t2.2. Список всех отделов и количество сотрудников в каждом отделе");
            foreach (var x in Data.Departments)
            {
                var q5 = from y in Data.DepartmentWorkers
                         where (y.DepartmentID == x.ID)
                         select y;
                Console.WriteLine(x + "; Количество: " + q5.Count());
            }
            
            Console.ReadLine();
        }
    }
}
