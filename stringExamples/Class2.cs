using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Class2
    {
        public void Duplicate()
        {
            Console.WriteLine("Enter a few numbers separated by '-': ");
            var inputUser = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(inputUser))
            {
                return;
            }

            var listNum = inputUser.Split('-').Select(Int32.Parse).ToList();

            for (var i = 0; i < listNum.Count; i++)
            {
                for (var j = i+1; j < listNum.Count; j++)
                {
                    if (listNum[i] == listNum[j])
                    {
                        Console.WriteLine("Duplicate");
                        return;
                    }
                }
            }

            Console.WriteLine("No Duplicate");


        }
    }
}