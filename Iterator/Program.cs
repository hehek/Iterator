using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteDatabase a = new ConcreteDatabase(5);        

            Iterator i = a.CreateIterator();
            object item = null;

            Console.WriteLine("To enter the iterator press \"Right Arrow\"");
            Console.WriteLine("Next item:" +" \"Right Arrow\"".PadLeft(22));
            Console.WriteLine("Previous item:" + " \"Left Arrow\"".PadLeft(17));
            Console.WriteLine("Exit the iterator:"+" \"N\"".PadLeft(2));
            Console.WriteLine("Exit the program:"+" \"Q\"".PadLeft(5));

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                    //Convert.ToInt16(Console.ReadKey(true).KeyChar.ToString()) - 1;

                if (key == ConsoleKey.Q)
                {
                    break;
                }
                if (key == ConsoleKey.N)
                {
                    item = null;
                    Console.WriteLine("\nWhoa!");
                }
                else if (key == ConsoleKey.LeftArrow && item !=null)
                {                   
                        item = i.Prev();
                        Console.Write(item+", ");                                      
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    if (item == null)
                    {
                        item = i.First();
                    }
                    else
                    {
                        item = i.Next();
                    }
                    Console.Write(item+", ");
                }
            }           
         
           


        }
    }
}
