using _261120PakjesLeveren.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _261120PakjesLeveren
{
    enum Firma
    {
        Bpost = 1,
        Express,
        NLPost,
        Dhl
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transactions.BpostUI();

            Transactions.DhlUI();
        }
    }
}
