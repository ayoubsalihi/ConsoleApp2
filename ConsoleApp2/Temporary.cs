using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal sealed class Temporary : Employee
    {
        public int taux_horaire;
        public int heurestravaillees;

        //constructeur
        public Temporary(string nom, string type_employee, int taux_horaire, int heurestravaillees)
            : base(nom, type_employee)
        {
            this.taux_horaire = taux_horaire;
            this.heurestravaillees = heurestravaillees;
        }
        /*je ne veux pas développer la partie getters et setters
         * c'est pour ça j'ai mis les attributs publique */

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Taux horaires: {taux_horaire}, heures travaillées");
        }
    }
}
