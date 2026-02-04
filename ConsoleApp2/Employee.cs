using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        public string nom;
        public string type_employee;

        public string TypeEmployee
        {
            get { return type_employee; }
            set {  type_employee = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Employee(string nom, string type_employee)
        {
            this.nom = nom;
            this.type_employee = type_employee;
        }
    }
}
