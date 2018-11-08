using System;
using System.Collections.Generic;

namespace AZNumbers
{
    class Program
    {

        Dictionary<int, string> dictionaryNumbers = new Dictionary<int, string>()
        {
            {0,"cero"}, {1,"uno"}, {2,"dos"}, {3,"tres"}, {4,"cuatro"}, {5,"cinco"},
            {6,"seis"}, {7,"siete"}, {8,"ocho"}, {9,"nueve"}, {10,"diez"}, {11,"once"},
            {12,"doce"}, {13,"trece"}, {14,"catorce"}, {15,"quince"},
            {20,"veinte"}, {30,"treinta"}, {40,"cuarenta"}, {50,"cincuenta"},
            {60,"sesenta"}, {70,"setenta"}, {80,"ochenta"}, {90,"noventa"},
            {100,"cien"}, {1000,"mil"}
        };

        static void Main(string[] args)
        {
            Program program = new Program();
            int count = 0;
            while(count < 10)
            {
                Console.WriteLine("Input your number");
                string number = Console.ReadLine();
                program.validator(number);
                count++;
            }
        }


        private void validator(string number)
        {
            string integerValue = string.Empty;
            string decimalValue = string.Empty;
            int integerNumber = -1;
            int decimalNumber = -1;

            string response = string.Empty; 

            if (number.Contains(","))
            {
                string[] numberComplete = number.Split(',');
                integerNumber = Convert.ToInt32(numberComplete[0]);
                decimalNumber = Convert.ToInt32(numberComplete[1]);
            }
            else
            {
                integerNumber = Convert.ToInt32(number);
            }

            if(integerNumber != -1)
            {
                dictionaryNumbers.TryGetValue(integerNumber, out integerValue);
                response = integerValue;
            }

            if (decimalNumber != -1)
            {
                dictionaryNumbers.TryGetValue(decimalNumber, out decimalValue);
                response = response + " con " + decimalValue;
            }

            Console.WriteLine(response + " Pesos Colombianos " + CurrencySymbol.COP);


        }

    }
}
