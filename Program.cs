using System;
using System.Globalization;

namespace ProgrammeDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            // Console.WriteLine(date.Year);

            CultureInfo cultureFrancais = CultureInfo.GetCultureInfo("fr-FR"); // sert à passer la langue en français après avoir installé le using, pour changer il faut par exemple passer le fr-FR en en-US pour de l'anglais

            Console.WriteLine(date.ToString("dddd dd MMMM yyyy HH:mm:ss", cultureFrancais));

            DateTime dateDemain = date.AddDays(1);

            Console.WriteLine("Demain : " + dateDemain.ToString("ddd dd MMMM yyyy HH:mm:ss", cultureFrancais));

            var diff = dateDemain - date;
            Console.WriteLine("Différence heures : " + diff.TotalHours + "h");
        }
    }
}
