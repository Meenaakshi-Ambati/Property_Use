using System;

namespace Property_use
{
    class Employee
    {
        int _eno;
        string _ename;

        public int Eno
        {
            set{
                if(value <= 0)
                throw new Exception("Employee Number can not be negative or Zero");

                _eno = value;

            }
            get {
                   return _eno;
            }
        }

            public string Ename 
            {
                get { return string.IsNullOrEmpty(this._ename) ? "No name " : this._ename; }
                set {
                    if (string.IsNullOrEmpty(value)) 
                    throw new Exception("employee name cannot be null or empty");

                this._ename = value;
                }
            }
            public string Email
             { get; set; }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Eno = 101;
            e1.Ename = "Meenaa";
            e1.Email = "Meenaakshi@Ambati.com";

            Console.WriteLine("{0} - {1} - {2}", e1.Eno, e1.Ename, e1.Email);
        }
    }
}
