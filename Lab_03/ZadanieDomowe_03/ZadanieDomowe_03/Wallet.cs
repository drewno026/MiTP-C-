using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_03
{
    internal class Wallet
    {
        public Document IdentityCard {  get; set; }
        public Document StudentCard { get; set; }

        public void CheckDate(int year)
        {
            if (IdentityCard != null)
            {
                if (IdentityCard.ExpirationDate < year)
                {
                    Console.WriteLine("Identity card is expired. ");
                }
                else
                {
                    Console.WriteLine("Identity card is up to date. ");
                }
            }
            if (StudentCard != null)
            {
                if (StudentCard.ExpirationDate < year)
                {
                    Console.WriteLine("Student card is expired. ");
                }
                else
                {
                    Console.WriteLine("Student card is up to date. ");
                }
            }
        }
    }
}
