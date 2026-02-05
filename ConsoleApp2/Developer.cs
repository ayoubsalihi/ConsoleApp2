using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal sealed class Developer : Employee
    {
        public int heures_supp;
        public float salaire;

        public Developer(string nom, string type_employee, int heures, float salaire)
            : base(nom, type_employee)
        {
            this.heures_supp = heures;
            this.salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Salaire: {salaire}€, Heures Supp: {heures_supp}");
        }

    }
}
