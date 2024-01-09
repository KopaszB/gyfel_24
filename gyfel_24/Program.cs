using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B.24.feladat: Olvassa be egy hónap számát, majd írja ki, hogy melyik évszakban van az adott hónap.

namespace gyfel_24
{
    class Program
    {
        static void Main()
        {
            int hszam = int.Parse(Console.ReadLine());
            EvszakNeve(hszam);
            Console.ReadLine();
        }

        static void EvszakNeve(double szam)
        {
            switch (szam)
            {
                case 12:
                case 1:
                case 2: Console.WriteLine("Tél van! Hol a perzselő?"); 
                        break;
                case 3:
                case 4:
                case 5: Console.WriteLine("Tavasz van! Ástál már?"); 
                        break;
                case 6:
                case 7:
                case 8: Console.WriteLine("Nyár van! Szénázni mikor fogsz?"); 
                        break;
                case 9:
                case 10:
                case 11: Console.WriteLine("Itt az ősz! Kukorica le van törve?"); 
                        break;

                default:
                    Console.WriteLine("Nincs ilyen hónap"); 
                    break;
            }
        }
    }
}
