using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_03
{
    public enum EyeColor
    {
        Green,
        Blue,
        Red,
        Brown
    }
    internal class Document
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public EyeColor EyeColor { get; set; }
        private int expirationDate;
        public int ExpirationDate 
        {  get { return expirationDate; }
            set
            {
                int CurrentYear = DateTime.Now.Year;
                if (value >= (CurrentYear - 5) && (value <= (CurrentYear + 100))) 
                {
                    expirationDate = value;
                }
                else
                {
                    throw new ArgumentException("Expiration date must be a realistic year.");
                }
            }
        }
        public Document(string firstName, string lastName, EyeColor eyeColor, int expirationDate)
        {
            FirstName = firstName;
            LastName = lastName;
            EyeColor = eyeColor;
            ExpirationDate = expirationDate;
        }
    }
}
