using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 6.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
a.	А или В; 
b.	А и В; 
c.	В или С.
*/

namespace HW_2._6_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            Console.Write("а. A или B = "); Console.WriteLine(A || B);
            Console.Write("b. A и B   = "); Console.WriteLine(A && B);
            Console.Write("c. B или C = "); Console.WriteLine(B || C);

            Console.ReadKey();
        }
    }
}
