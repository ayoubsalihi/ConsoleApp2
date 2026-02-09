using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
        private string nom;
        private string type_employee;

        public string TypeEmployee
        {
            get { return type_employee; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Le type d'employé ne peut pas être nul");
            }
        }
        public string Nom
        {
            get { return nom; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Le nom ne peut pas être nul");
                nom = value;
            }
        }
        public Employee(string nom, string type_employee)
        {
            this.nom = nom;
            this.type_employee = type_employee;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Poste: {TypeEmployee}");
        }
    }
}
