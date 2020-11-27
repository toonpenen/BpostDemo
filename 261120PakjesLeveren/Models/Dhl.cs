using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261120PakjesLeveren.Models
{
   public class Dhl : Bpost
    {
        public override void PackageRecived()
        {
            Console.WriteLine("Package recived by DHL"); 
        }

        public override void Deliverd()
        {
            Console.WriteLine("Package is deliverd by DHL");
            SmsConfirmationToBPost();
        }

        public override void SmsConfirmationToBPost()                            
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"By this SMS we confirm the{TransactionId} is deliverd");
            Console.WriteLine($"Deliverd at: {DeliverAddress}");
            Console.ResetColor();
        }

        public override void PrintTotalNumberOfPackagesDeliverd()                
        {
            Console.WriteLine($"Total Packages {count}");
        }
    }
}
