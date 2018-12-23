namespace Lab7
{
    class Worker//Сотрудник
    {
        public int ID;//Первичный ключ
        public string Surname;//Фамилия
        public int DepartmentID;//ID отдела

        public Worker(int id, string sn, int dep)
        {
            ID = id;
            Surname = sn;
            DepartmentID = dep;
        }

        public override string ToString()
        {
            return "ID: " + ID + "; Фамилия: " + Surname + "; ID_Отдела: " + DepartmentID;
        }
    }

    class Department //Отдел
    {
        public int ID;//ID отдела
        public string Name;//Название

        public Department(int id, string nm)
        {
            ID = id;
            Name = nm;
        }

        public override string ToString()
        {
            return "ID: " + ID + "; Название отдела: " + Name;
        }
    }

    class DepartmentWorker//Класс сотрудники отдела
    {
        public int WorkerID;//ID работника
        public int DepartmentID;//ID отдела

        public DepartmentWorker(int idW, int idD)
        {
            WorkerID = idW;
            DepartmentID = idD;
        }
    }
}