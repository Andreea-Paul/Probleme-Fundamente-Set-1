using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Fundamente_Set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce-ti un numar de la 1 la 21 pentru a selecta problema dorita");
            switch (Console.ReadLine())
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    P3();
                    break;
                case "4":
                    P4();
                    break;
                case "5":
                    P5();
                    break;
                case "6":
                    P6();
                    break;
                case "7":
                    P7();
                    break;
                case "8":
                    P8();
                    break;
                case "9":
                    P9();
                    break;
                case "10":
                    P10();
                    break;
                case "11":
                    P11();
                    break;
                case "12":
                    P12();
                    break;
                case "13":
                    P13();
                    break;
                case "14":
                    P14();
                    break;
                case "15":
                    P15();
                    break;
                case "16":
                    P16();
                    break;
                case "17":
                    P17();
                    break;
                case "18":
                    P18();
                    break;
                case "19":
                    P19();
                    break;
                case "20":
                    P20();
                    break;
                case "21":
                    P21();
                    break;
            }
        }
        /// <summary>
        /// 21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
        /// </summary>
        private static void P21()
        {
            Random rnd = new Random();
            int number, n = 0;
            number = rnd.Next(1, 1025);

            Console.WriteLine("Incearca sa ghicesti numarul calculatorului.Introduce-ti un numar intre 1 si 1024");

            while (n != number)
            {
                n = int.Parse(Console.ReadLine());
                if (n < number)
                {
                    Console.WriteLine($"Numarul calculatorului este mai mare decat {n}.Incearca din nou.");
                }
                else if (n > number)
                {
                    Console.WriteLine($"Numarul calculatorului este mai mic decat {n}.Incearca din nou");
                }
            }
            Console.WriteLine($"Ai ghicit.Numarul este {number}");
        }
        /// <summary>
        /// 20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).
        /// </summary>
        private static void P20()
        {
            int m, n,parte_intreaga,parte_fractionara,cifra,rest;
            bool periodicitate;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            Console.WriteLine("Introduce-ti un numarator intreg");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce-ti un numitor intreg diferit de 0");
            n = int.Parse(Console.ReadLine());

            parte_intreaga = m / n;
            Console.WriteLine($"Rezultatul este {parte_intreaga},");
            parte_fractionara = m % n;

            resturi.Add(parte_fractionara);
            periodicitate = false;

            do
            {
                cifra = parte_fractionara * 10 / n;
                cifre.Add(cifra);
                rest = parte_fractionara * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodicitate = true;
                    break;
                }
                parte_fractionara = rest;
            }
            while (rest != 0);

            if (!periodicitate)
            {
                foreach(int cif in cifre)
                {
                    Console.WriteLine(cif);
                }
            }
            else
            {
                for(int i= 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.WriteLine("(");
                    }
                    Console.WriteLine(cifre[i]);
                }
                Console.WriteLine(")");
            }
            
        }
        /// <summary>
        /// 19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        /// </summary>
        private static void P19()
        {
            int n, r, l;
            l = 0;
            Console.WriteLine("Introduce-ti un numar intreg");
            n = int.Parse(Console.ReadLine());
            int[] counter = new int[10];
            while (n != 0)
            {
                r = n % 10;
                counter[r]++;
                n = n / 10;
            }
            foreach (int i in counter)
            {
                if (i != 0)
                    l++;
            }
            if (l == 1)
                Console.WriteLine("Numarul contine doar o cifra care se repeta");
            if (l == 2)
                Console.WriteLine("Numarul contine doar doua cifre care se repeta");
            if (l > 2)
                Console.WriteLine("Numarul contine mai mult de doua cifre care se repeta");
            
        }
        /// <summary>
        /// 18.Afisati descompunerea in factori primi ai unui numar n.
        /// </summary>
        private static void P18()
        {
            int n, i, x;
            Console.WriteLine("Introduce-ti un numar intreg");
            n = int.Parse(Console.ReadLine());
            x = 0;
            for (i = 2; n > 1; i++)
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                        x += 1;
                    }
                    Console.WriteLine($"{i}^{x} ");
                }
        }
        /// <summary>
        /// 17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        /// </summary>
        private static void P17()
        {
            int a, b;

            Console.WriteLine("Introduce-ti primul numar");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti al doilea numar");
            b = int.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else 
                    b = b - a;
            }
            Console.WriteLine($"CMMDC prin algoritmul lui Euclid este {a}");
        }
        /// <summary>
        /// 16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
        /// </summary>
        private static void P16()
        {
            int a, b, c, d, e, aux;
            List<int>numere=new List<int>();
            Console.WriteLine("Introduce-ti primul numar");
            a = int.Parse(Console.ReadLine());
            numere.Add(a);
            Console.WriteLine("Introduce-ti al doilea numar");
            b = int.Parse(Console.ReadLine());
            numere.Add(b);
            Console.WriteLine("Introduce-ti al treilea numar");
            c = int.Parse(Console.ReadLine());
            numere.Add(c);
            Console.WriteLine("Introduce-ti al patrulea numar");
            d = int.Parse(Console.ReadLine());
            numere.Add(d);
            Console.WriteLine("Introduce-ti al cincilea numar");
            e = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a;a = b;b = aux;
            }
            if (a > c)
            {
                aux = a;a = c;c = aux;
            }
            if (a > d)
            {
                aux=a;a = d;d = aux;
            }
            if(a > e)
            {
                aux = a;a = e;e = aux;
            }
            if(b > c)
            {
                aux = b;b = c;c = aux;
            }
            if (b > d)
            {
                aux = b;b = d;d = aux;
            }
            if (b > e)
            {
                aux = b;b = e;e = aux;
            }
            if (c > d)
            {
                aux = c;c = d;d = aux;
            }
            if(c > e)
            {
                aux = c;c = e;e = aux;
            }
            if(d > e)
            {
                aux = d;d = e;e = aux;
            }
            Console.WriteLine($"{a} {b} {c} {d} {e}");
           
        }
        /// <summary>
        ///15.Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        private static void P15()
        {
            int a, b, c, aux;
            Console.WriteLine("Introduce-ti primul numar");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti al doilea numar");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti al treilea numar");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                aux = a; a = b; b = aux;
            }
            if (a > c)
            {
                aux = a; a = c; c = aux;
            }
            if (b > c)
            {
                aux = b; b = c; c = aux;
            }
            Console.WriteLine($"Valorile ordonate sunt:{a},{b},{c}");
        }
        /// <summary>
        /// 14.Determianti daca un numar n este palindrom.
        /// </summary>
        private static void P14()
        {
            int n, inv, rest, n1;

            Console.WriteLine("Introduce-ti un numar intreg");
            n = int.Parse(Console.ReadLine());
            n1 = n;
            inv = 0;
            while (n != 0)
            {
                rest = n % 10;
                inv = inv * 10 + rest;
                n /= 10;
            }
            if (n1 == inv)
                Console.WriteLine($"Numarul {n1} este palindrom");
            else
                Console.WriteLine($"Numarul {n1} nu este palindrom");
        }
        /// <summary>
        /// 13.Determinati cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void P13()
        {
            int y, y1, y2, l;

            Console.WriteLine("Introduce-ti primul an al intervalului");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti ultimul an al intervalului");
            y2 = int.Parse(Console.ReadLine());
            l = 0;
            for (y = y1; y <= y2; y++)
            {
                if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
                {
                    l += 1;
                }
            }
            Console.WriteLine($"In intervalul {y1}-{y2} exista {l} ani bisecti");
        }
        /// <summary>
        /// 12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
        /// </summary>
        private static void P12()
        {
            int i, n, a, b, l;
            Console.WriteLine("Introduce-ti un numar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti primul numar al intervalului");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti ultimul numar al intervalului");
            b = int.Parse(Console.ReadLine());

            l = 0;

            for (i = a; i <= b; i++)
            {
                if (n % i == 0)
                    l += 1;

            }
            Console.WriteLine($"In intervalul {a}-{b} exista {l} divizori ai numarului {n}");
        }
        /// <summary>
        /// 11.Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        private static void P11()
        {
            int a, uc;
            Console.WriteLine("Introduce-ti un numar intreg");
            a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                uc = a % 10;
                a = a / 10;
                Console.WriteLine($"{uc}");
            }
        }
        /// <summary>
        /// 10.Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        private static void P10()
        {
            int a, i,n;
            n = 0;
            Console.WriteLine("Introduce-ti un numar intreg");
            a=int.Parse(Console.ReadLine());
            if(a==0 || a==1)
                Console.WriteLine($"{a} nu este un numar prim");
            else
            {
                for(i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                        n++;
                }
                if (n == 2)
                    Console.WriteLine($"{a} este un numar prim");
                else
                    Console.WriteLine($"{a} nu este un numar prim");

            }
                



        }
        /// <summary>
        /// 9.Afisati toti divizorii numarului n. 
        /// </summary>
        private static void P9()
        {
            int i, n;
            Console.WriteLine("Introduce-ti un numar intreg");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("{0}", i);
            }
        }
        /// <summary>
        /// 8.Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. 
        /// </summary>
        private static void P8()
        {
            int a, b;
            
            Console.WriteLine("Introduce-ti un numar intreg a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti un numar intreg b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Inainte de inversare, a={a} si b={b}");

            a = a * b;    
            b = a / b;     
            a = a / b;

            Console.WriteLine($"Dupa inversare, a={a} si b={b}");

        }
        /// <summary>
        /// 7.Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        /// </summary>
        private static void P7()
        {
            int a, b,aux;
            aux = 0;
            Console.WriteLine("Introduce-ti un numar intreg a");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti un numar intreg b");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine($"Inainte de inversare, a={a} si b={b}");

            aux =a;
            a = b;
            b = aux;

            Console.WriteLine($"Dupa inversare, a={a} si b={b}");
        }
        /// <summary>
        /// 6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        /// </summary>
        private static void P6()
        {
            float a, b, c;

            Console.WriteLine("Introduce-ti prima lungime");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti a doua lungime");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti a treia lungime");
            c = float.Parse(Console.ReadLine());

            if ((a < b + c) && (b < c + a) && (c < a + b) && (a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("Lungimile pot forma un triunghi");
                if ((a == c) && (a == b))
                    Console.WriteLine("Triunghiul este echilateral");
                else if ((a == b) || (a == c) || (b == c))
                    Console.WriteLine("Triunghiul este isoscel");
                else
                    Console.WriteLine("Triunghiul este un oarecare");
            }
            else
                Console.WriteLine("Lungimile nu pot forma un triunghi");
            

        }
        /// <summary>
        /// 5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        /// </summary>
        private static void P5()
        {
            int n, k, uc, counter;
            Console.WriteLine("Introduce-ti un numar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Al cata cifra de la finalul numarului doresti sa extragi? Introdu valoarea ca si un numar intreg");
            k = int.Parse(Console.ReadLine());
            counter = 0;
            while (n != 0)
            {
                uc = n % 10;
                counter++;
                if (counter == k)
                {
                    Console.WriteLine($"Cifra {k} de la finalul numarului este {uc}"); break ;
                }
                n = n / 10;

            }
        }
        /// <summary>
        /// 4.Determinati daca un an y este an bisect. 
        /// </summary>
        private static void P4()
        {
            int a;

            Console.WriteLine("Introduceti un an");
            a = int.Parse(Console.ReadLine());

            if ((a % 400 == 0) || (a % 4 == 0 && a % 100 != 0))
            {
                Console.WriteLine($"{a} este un an bisect");
            }

            else
            {
                Console.WriteLine($"{a} nu este un an bisect");
            }
        }
        /// <summary>
        /// 3.Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
        /// </summary>
        private static void P3()
        {
            float n, k;
            Console.WriteLine("Introduce-ti divizatul");
            n = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti divizorul");
            k = float.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine($"{k} il divide pe {n}");
            }
            else
            {
                Console.WriteLine($"{k} nu il divide pe {n}");
            }
        }
        /// <summary>
        /// 2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        /// </summary>
        private static void P2()
        {
            float a, b, c, x1, x2, d;
            
            Console.WriteLine("Introduce-ti coeficintul a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti coeficintul b");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce-ti coeficintul a");
            c = float.Parse(Console.ReadLine());

            if (a != 0 && b!=0 && c!=0)
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                    Console.WriteLine("Radacinile ecuatiei sunt complexe");
                else
                {
                    x1 = (float)(-b + Math.Sqrt(d) / (2 * a));
                    x2 = (float)(-b - Math.Sqrt(d) / (2 * a));
                    Console.WriteLine($"Cele doua solutii ale ecuatiei sunt {x1} si {x2}");
                }
            }


            if (a==0 && b != 0 && c!=0)
            {
                x1 = -c / b;
                Console.WriteLine($"Ecuatia este de gradul I si rezultatul ei este {x1}");
            }

            if(a!=0 && b==0 && c != 0)
            {
                x1 = (float)Math.Sqrt(-c / a);
                Console.WriteLine($"Rezultatul ecuatiei este {x1}");
            }
            
            
            if (a != 0 && b != 0 && c == 0)
                  Console.WriteLine("Rezultatul ecuatiei este intotdeauna 0");
            else
                  Console.WriteLine("Ecuatie nu se poate rezolva");
            


        }
        /// <summary>
        /// 1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        /// </summary>
        private static void P1()
        {
            float a, b, x;

            Console.WriteLine("Scrie-ti coeficientul a al ecuatiei");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Scrie-ti coeficientul b al ecuatiei");
            b = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine($"Solutia ecuatiei este {x}");
            }
            else
            {
                if (b == 0)
                    Console.WriteLine("Ecuatia este nedeterminata");
                else
                    Console.WriteLine("Nu este ecuatie");
            }

        }
    }
}
