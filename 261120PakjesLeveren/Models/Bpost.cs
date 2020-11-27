using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261120PakjesLeveren.Models
{
   public class Bpost
    {
        public static int count;
        public string TransactionId { get; set; }
        public string DeliverAddress { get; set; }

        public virtual void PackageRecived()  // virtual zodat child class eraan kan
        {
            Console.WriteLine("Package recived by Bpost");
        }

        public Bpost()
        {
            count++;
        }

        public virtual void PackagaOnTheWay()
        {
            Console.WriteLine("Package is on the way to client");
        }

        public virtual void Deliverd()
        {
            Console.WriteLine("Package is deliverd by Bpost");
            SmsConfirmationToBPost();
        }

        public virtual void SmsConfirmationToBPost()
        {
            Console.ForegroundColor = ConsoleColor.Green;     
            Console.WriteLine($"By this SMS we confirm the{TransactionId} is deliverd");
            Console.WriteLine($"Deliverd at: {DeliverAddress}");
            Console.ResetColor();
        }

        public virtual void PrintTotalNumberOfPackagesDeliverd()
        {
            Console.WriteLine($"Total Packages {count}");
        }
    }
}
