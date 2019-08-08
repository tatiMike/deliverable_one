using System;
using System.Globalization;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstAmount;
            Console.WriteLine("Please enter your first amount: ");
            firstAmount = Convert.ToDecimal(Console.ReadLine());

            decimal secondAmount;
            Console.WriteLine("Please enter your second amount: ");
            secondAmount = Convert.ToDecimal(Console.ReadLine());

            decimal thirdAmount;
            Console.WriteLine("Please enter your third amount: ");
            thirdAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Average Amount: ");
            decimal averageAmount = (firstAmount + secondAmount + thirdAmount) / 3;
            Console.WriteLine(Math.Round(averageAmount, 2));

                if (firstAmount <= secondAmount & firstAmount < thirdAmount)
                {
                Console.Write("Smallest Amount: ");
                Console.WriteLine(firstAmount);
                }
                    else if(secondAmount <= firstAmount & secondAmount < thirdAmount)
                    {
                Console.Write("Smallest Amount: ");
                Console.WriteLine(secondAmount);
                    }
                    else if(thirdAmount <= firstAmount & thirdAmount < secondAmount)
                    {
                Console.Write("Smallest Amount: ");
                Console.WriteLine(thirdAmount);
                    }

                if (firstAmount >= secondAmount & firstAmount > thirdAmount)
                {
                Console.Write("Largest Amount: ");
                Console.WriteLine(firstAmount);
                }
                    else if (secondAmount >= firstAmount & secondAmount > thirdAmount)
                    {
                Console.Write("Largest Amount: ");
                Console.WriteLine(secondAmount);
                    }
                    else if (thirdAmount >= firstAmount & thirdAmount > secondAmount)
                    {
                Console.Write("Largest Amount: ");
                Console.WriteLine(thirdAmount);
                    }

            var totalAmountUS = (firstAmount + secondAmount + thirdAmount);
            var specifierUS = "C";
            var cultureUS = CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine(totalAmountUS.ToString(specifierUS, cultureUS));

            var totalAmountSEK = (firstAmount + secondAmount + thirdAmount);
            var specifierSEK = "C";
            var cultureSEK = CultureInfo.CreateSpecificCulture("sv-SE");
            Console.WriteLine(totalAmountSEK.ToString(specifierSEK, cultureSEK));

            var totalAmountJP = (firstAmount + secondAmount + thirdAmount);
            var specifierJP = "C";
            var cultureJP = (CultureInfo.CreateSpecificCulture("ja-JP"));
            Console.WriteLine(totalAmountJP.ToString(specifierJP, cultureJP));

            var totalAmountTH = (firstAmount + secondAmount + thirdAmount);
            var specifierTH = "C";
            var cultureTH = CultureInfo.CreateSpecificCulture("th-TH");
            Console.WriteLine(totalAmountTH.ToString(specifierTH, cultureTH));

        }
    }
}
