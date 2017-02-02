using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        // correct conversion 64f <= 32f<= 64<=32<=16<=8
        static void Main(string[] args)
        {
           
                WideningCasting wideningCasting = new WideningCasting();
                wideningCasting.conversion();
                Console.ReadLine();

                NarrowingCasting narrowing = new NarrowingCasting();
                narrowing.Narrowing();
                Console.ReadLine();
        }

        
    }
}
