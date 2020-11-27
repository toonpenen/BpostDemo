using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _261120PakjesLeveren.Models
{
    public class Transactions       //HELPER CLASS
    {

        public static void BpostUI()
        {
            string line = new string('*', 55);

            Bpost bpost = new Bpost();

            Database db = new Database();
            Console.ForegroundColor = ConsoleColor.Yellow;
            bpost.DeliverAddress = "HalveMaanstraat 12 Gent";
            bpost.TransactionId = "123456789/2020/11";
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(db.GetAdress((int)Firma.Bpost));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            bpost.PackageRecived();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            bpost.PackagaOnTheWay();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            bpost.Deliverd();
            bpost.PrintTotalNumberOfPackagesDeliverd();
            Console.ResetColor();
            Console.WriteLine($"\n{line}");
        }

        public static void DhlUI()
        {
            string line = new string('*', 55);

            Dhl dhl = new Dhl();

            Database db = new Database();
            Console.ForegroundColor = ConsoleColor.Yellow;
            dhl.DeliverAddress = "Zondernaamstraat 12 Antwerpen";
            dhl.TransactionId = "7788991122/2020/07";
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(db.GetAdress((int)Firma.Dhl));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            dhl.PackageRecived();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            dhl.PackagaOnTheWay();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            dhl.Deliverd();
            dhl.PrintTotalNumberOfPackagesDeliverd();
            Console.ResetColor();
            Console.WriteLine($"\n{line}");

        }
    }
}
