using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261120PakjesLeveren.Models
{
    public class Database
    {
        private string Name { get; set; }
        private string OfficeAdress { get; set; }
        private string PostCode { get; set; }
        private string City { get; set; }
        private string Country { get; set; }

        private int _id;

        public int Id
        {
            get { return _id; }
            set 
            {
                if (value > 4 || value < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong client Id");
                    Console.ResetColor();
                }      
            }
        }

        public override string ToString()
        {
            return $"Contact us on: \nName:{Name} \nAdress:{OfficeAdress} \nPostcode:{PostCode}  City:{City}  Country:{Country}";        
        }

        public Database GetAdress(int firma)//1,2,3,4 mogelijke waardes
        {
            Database office = null;
            switch (firma)
            {
                case 1:
                    Database office1 = new Database()
                    {
                        Id = 001,
                        Name = "Bpost",
                        City = "Brussel",
                        OfficeAdress = "Intecstraat 12",
                        PostCode = "1000",
                        Country = "Belgie",
                    };
                    office = office1;
                    return office;
                case 2:
                    Database office2 = new Database()
                    {
                        Id = 002,
                        Name = "Express",
                        City = "Antwerpen",
                        OfficeAdress = "Antwaarpsestraat 2",
                        PostCode = "2000",
                        Country = "Belgie",
                    };
                    office = office2;
                    return office;

                case 3:
                    Database office3 = new Database()
                    {
                        Id = 003,
                        Name = "NlPost",
                        City = "Amsterdam",
                        OfficeAdress = "Kaasstraat 12",
                        PostCode = "1008-AG",
                        Country = "Nederland",
                    };
                    office = office3;
                    return office;

                case 4:
                    Database office4 = new Database()
                    {
                        Id = 004,
                        Name = "Dhl",
                        City = "Gent",
                        OfficeAdress = "LeiKaai 48",
                        PostCode = "9000",
                        Country = "Belgie",
                    };
                    office = office4;
                    return office;
                    default:
                    return office; 
            }
        }
    }
}
