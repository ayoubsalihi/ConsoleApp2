using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal sealed class Manager : Employee
    {
        private int membres_equipe;
        private float salaire;

        //constructeur
        public Manager(string nom, string type_employee, int membres_equipe, float salaire)
            : base(nom, type_employee)
        {
            this.membres_equipe = membres_equipe;
            this.salaire = salaire;
        }
        // getters et setters
        public int MembresEquipes
        {
            get
            {
                return membres_equipe;
            }
            set
            {
                membres_equipe = value;
            }
        }

        public float Salaire
        {
            get
            {
                return salaire;
            }
            set
            {
                salaire = value;
            }
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Salaire: {salaire}, Membres d'équipe: {membres_equipe}");
        }
    }
}
