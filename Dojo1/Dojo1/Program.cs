using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Program
    {
        static void Main(string[] args)
            //This code is quite simple, to be honest.
        {
            Console.WriteLine("Welcome to TemperatureConverter! Start by choosing one of the following temperature units:");
            Console.WriteLine("1: Celsius\n2: Fahrenheit\n3: Réaumur\n4: Kelvin");
            int unit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen: {0}", unit1);
            Console.WriteLine("Enter temperature to be converted:");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose unit to which temperature is converted:");
            Console.WriteLine("1: Celsius\n2: Fahrenheit\n3: Réaumur\n4: Kelvin");
            int unit2 = Convert.ToInt32(Console.ReadLine());

            //every unit (except from Celsius) is converted to Celsius and then converted to the unit which was chosen by the user
            double temp2 = 0;
            if (unit1 == 1) {//Celsius
                temp2 = temp;
            } else if (unit1 == 2) { //Fahrenheit to Celsius
                temp2 = (temp-32)*(5/9);
            } else if (unit1 == 3) //Réaumur to Celsius
            {
                temp2 = temp*1.25;
            } else //Kelvin to Celsius
            {
                temp2 = temp-273.15;
            }
            //every value (except from Celsius) is converted to the respective unit
            if (unit2 == 1)
            {//Celsius
                temp = temp2;
            }
            else if (unit2 == 2)
            { //Celsius to Fahrenheit
                temp = temp2 * 1.8 + 32;
            }
            else if (unit2 == 3) //Celsius to Réaumur
            {
                temp = temp2 * 0.8;
            }
            else //Celsius to Kelvin
            {
                temp = temp2+273.15;
            }

            Console.WriteLine("Result: {0}", temp);
            Console.ReadLine();
        }
    }
}
