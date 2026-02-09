using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal sealed class Consultant: Employee
    {
        public string titre;
        public int duree;
        public float cout_journalier;

        public Consultant(string nom, string type_employee, string titre, int duree, float cout_journalier)
            :base(nom,type_employee)
        {
            this.titre = titre;
            this.duree = duree;
            this.cout_journalier = cout_journalier;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Titre du consultant: {titre}, durée: {duree} et le coùt journalier: {cout_journalier}");
        }
    }
}
