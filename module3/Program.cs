using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace module3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake<string> Cake = new Cake<string>();

            Cake.type = "Wedding Cake";
            Cake.flavor = "Vanilla";

            Cake<string> Cake1 = new Cake<string>();
            Cake1.type = "Birthday Cake";
            Cake1.flavor = "Chocolate";

            Console.WriteLine("My favorite cake is" + Cake.type
                     + "with the flavor of" + Cake.flavor + "I don't like my" + Cake1.type
                     + "it has the flavor of" + Cake.flavor);
                




            
        }
    }
}
public class Cake<T>
{
    public T type { get; set; }
    public T flavor { get; set; }


}
