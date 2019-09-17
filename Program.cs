using System;

namespace önings_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv nummer för välja uppgift");
            Console.WriteLine("upgift 1, Uppgift 2, Uppgift 3, upgift 4");
            int val = Convert.ToInt32(Console.ReadLine());

            //UppGift 1
            if (val == 1)
            {
                Console.WriteLine("Skriv in heltal 1");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in heltal 2");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int sum = n1 + n2;
                int pro = n1 * n2;
                int dif = n1 - n2;
                int kvo = n1 / n2;
                Console.WriteLine("Summa: " + sum + " Produkt: " + pro + " Differens: " + dif + " Kvot: " + kvo);
            }

            //uppgift 2
            else if (val == 2)
            {
                Console.WriteLine("Skriv höjden på din triangel");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv bredden på din triangel");
                int b = Convert.ToInt32(Console.ReadLine());
                int om1 = h * 2 + b * 2;
                int ae1 = h * 2;
                int om2 = om1 / 2;
                int ae2 = ae1 / 2;
                Console.WriteLine("Arean: " + ae2 + " Omkrets: " + om2);
            }

            //uppgift 3
            else if (val == 3) {
                Console.WriteLine("El avgift beräkning. Fast avgift 100kr, kwhpris är 50kr");
                int kwhp = 50;
                int fp = 100;
                Console.WriteLine("Skriv El användningen för första delen av kvartalet");
                int p1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv El användningen för sista delen av kvartalet");
                int p2 = Convert.ToInt32(Console.ReadLine());
                int p = p2 - p1;
                int to = kwhp * p + fp;
                Console.WriteLine("Totalkostnaden är "+to+"kr");
            }

            //uppgift 4
            if (val == 4) {
                Console.WriteLine("Rabatt räknare 3000 version 67");
                Console.WriteLine("Skriv priset på produkten");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("Skriv procenthalten på rean");
                double pro = double.Parse(Console.ReadLine());
                double pro2 = pro * 0.01;
                double pro3 = 1.00 - pro2;
                double sum = pro3 * p;
                Console.WriteLine("Priset blir: "+sum+"kr");
            }

            //uppgift 5
            if (val == 5) {
                Console.WriteLine("VÄLKOMMEN TILL MÄSSAN");
                Console.WriteLine("Hur många kommer?");
                int a = int.Parse(Console.ReadLine());
                int age = 0;
                int total = 0;
                while (a > 0) {
                    Console.WriteLine("Hur gammal är första personen?");
                    age = int.Parse(Console.ReadLine());
                    if (age < 10) { }

                    else if (age >= 10 & age <= 20)
                    {
                        total += 50;
                    }

                    else if (age > 20) {
                        total += 75;
                    }
                    a--;
                }
                Console.WriteLine("Summan blir: "+total+"kr");
            }
        }
    }
}
