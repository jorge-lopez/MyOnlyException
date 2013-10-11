using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    class Program
    {
        static void Main(string[] args)

        {
            //How hayley came up with a song

            while (true)
            {
                try
                {
                    Console.Write("You are ");
                    throw new MyException("The only exception");
                }

                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
