using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyApp
{
    internal class CriminalsList
    {
        List<(string Imię, string Nazwisko)> osoby = new()
            {
                ("Jan", "Kowalski"),
                ("John", "Doe")
            };
        public bool CzyOsobaJestPoszukiwana(string imię, string nazwisko)
        {
         if (osoby.Contains((imię, nazwisko))){
                return true;
            }
         return false;
        }
    }
}
