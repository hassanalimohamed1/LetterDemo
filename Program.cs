using System;
using static System.Console;
namespace LetterDemo
{
    class LetterDemo
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter();
            CertifiedLetter letter2 = new CertifiedLetter();

            letter1.Name = "Energex";
            letter1.Date = "03/06/2021";
            letter2.Name = "Telstra";
            letter2.Date = "01/06/2021";
            letter2.TrackingNumber = "0035348765387";


            WriteLine(letter1.ToString());
            WriteLine();
            WriteLine(letter2. ToString() + ", Tracking Number: " + letter2.TrackingNumber);
        }
    }// class ends

    class Letter
    {
        public string Name { set; get; }
        public string Date { set; get; }

        public new string ToString()
        {
            return (GetType() + "To: " + Name + ", Date: " + Date);
        }
    }// class ends

    class CertifiedLetter : Letter
    {
        public string TrackingNumber { set; get; }
    }
}
