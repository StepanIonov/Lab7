using System.Collections.Generic;

namespace Lab7
{
    class Data
    {
        internal static List<Worker> Workers { get; } = new List<Worker>()//Список сотрудников
        {
            new Worker(1, "Петров", 1),
            new Worker(2, "Иванов", 2),
            new Worker(3, "Алтуфьев", 1),
            new Worker(4, "Игнатьева", 3),
            new Worker(5, "Прокофьев", 2),
            new Worker(6, "Александрова", 1),
            new Worker(7, "Алексеев", 3),
        };

        internal static List<DepartmentWorker> DepartmentWorkers { get; } = new List<DepartmentWorker>//Список сотрудников отдела
        {
            new DepartmentWorker(1,1),
            new DepartmentWorker(1,2),
            new DepartmentWorker(1,3),
            new DepartmentWorker(2,1),
            new DepartmentWorker(3,1),
            new DepartmentWorker(3,3),
            new DepartmentWorker(4,3),
            new DepartmentWorker(5,2),
            new DepartmentWorker(6,1),
            new DepartmentWorker(7,2),
            new DepartmentWorker(7,3)
        };

        internal static List<Department> Departments { get; } = new List<Department>()//Список отделов
        {
            new Department(1, "Отдел продаж"),
            new Department(2, "Отдел закупок"),
            new Department(3, "Отдел кадров"),
        };
    }
}
