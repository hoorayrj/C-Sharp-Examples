using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Problem1
    {
        public void Consec()
        {
            Console.WriteLine("Enter a series of numbers sepearated by a dash '-': ");
            var userInput = Console.ReadLine();

            var numbers = userInput.Split("-");

            var consec = true;

            var prev = Convert.ToInt32(numbers[0]);
            var i = Convert.ToInt32(1);

            while (i < numbers.Length)
            {
                if (prev + 1 == Convert.ToInt32(numbers[i]))
                {
                    prev = Convert.ToInt32(numbers[i]);
                    i++;
                }
                else
                {
                    consec = false;
                    i++;
                }

            }

            if (consec == false)
                Console.WriteLine("String is not conseutive");
            else
                Console.WriteLine("String is consecutive");

        }
    }
}
