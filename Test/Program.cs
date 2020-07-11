using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static int t = 20;

        //static void Main(string[] args)
        //{
        //    int s = 0;
        //    int a = 1;

        //    string yazi = " DUNYAYI GUZELLIK KURTARACAK BIR INSANI SEVMEKLE BASLAYACAK HER SEY SEN YETERKI UMUDUNU KAYBETME BIRLIKTE COK GUZELIZ BIRLIKTE COK GULERIZ";
        //    while (true)
        //    {
        //        foreach (var item in yazi)
        //        {
        //            writeChar(item);
        //        }
        //    }

        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Id = 9, ParentId = 8, Name = "Ercan" });
            people.Add(new Person() { Id = 8, ParentId = 7, Name = "Yusuf" });
            people.Add(new Person() { Id = 3, ParentId = 2, Name = "Ali" });
            people.Add(new Person() { Id = 1, ParentId = null, Name = "Ahmet" });
            people.Add(new Person() { Id = 2, ParentId = 1, Name = "Nihal" });
            people.Add(new Person() { Id = 11, ParentId = 10, Name = "Rehmi" });
            people.Add(new Person() { Id = 6, ParentId = 5, Name = "Aydeniz" });
            people.Add(new Person() { Id = 4, ParentId = 3, Name = "Burak" });
            people.Add(new Person() { Id = 5, ParentId = 4, Name = "Tuğberk" });
            people.Add(new Person() { Id = 7, ParentId = null, Name = "Arzu" });
            people.Add(new Person() { Id = 10, ParentId = 9, Name = "Samed" });

            foreach (var person in people)
                person.ParentPerson = people.FirstOrDefault(c => c.Id == person.ParentId);

            List<Person> sortPeople = new List<Person>();

            foreach (var firstPerson in people.Where(c => !c.ParentId.HasValue))
            {
                var person = firstPerson;
                while (person != null)
                {
                    sortPeople.Add(person);
                    person = people.OrderBy(c => c.Id).FirstOrDefault(c => c.ParentId == person.Id);
                }
            }

            Console.WriteLine("Ordered");

            foreach (var person in sortPeople)
                Console.WriteLine(person);

            Console.ReadKey();
        }

        double A(int n, double x, double y)
        {
            return (toplam(n, Math.Pow(x, 2)) * toplam(n, y) - toplam(n, x) * toplam(n, x * y)) / (n * toplam(n, Math.Pow(n, x)) - (Math.Pow(toplam(n, x), 2)));
        }

        double B(int n, double x, double y)
        {
            return (n * toplam(n, x * y) - toplam(n, x) * toplam(n, y)) / (n * toplam(n, Math.Pow(n, x)) - (Math.Pow(toplam(n, x), 2)));
        }

        double toplam(int n, double a)
        {
            double sonuc = 0;
            for (int i = 0; i < n; i++)
                sonuc += a;
            return sonuc;
        }

        class Person
        {
            public int Id { get; set; }
            public int? ParentId { get; set; }
            public string Name { get; set; }
            public Person ParentPerson { get; set; }
            public override string ToString()
            {
                return $"{Id} - {Name}";
            }
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method async >>>>>>>>>");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method");
            }
        }

        static void writeChar(char c)
        {
            switch (c)
            {
                case 'A':
                    A();
                    break;
                case 'B':
                    B();
                    break;
                case 'C':
                    C();
                    break;
                case 'D':
                    D();
                    break;
                case 'E':
                    E();
                    break;
                case 'F':
                    F();
                    break;
                case 'G':
                    G();
                    break;
                case 'H':
                    H();
                    break;
                case 'I':
                    I();
                    break;
                case 'J':
                    J();
                    break;
                case 'K':
                    K();
                    break;
                case 'L':
                    L();
                    break;
                case 'M':
                    M();
                    break;
                case 'N':
                    N();
                    break;
                case 'O':
                    O();
                    break;
                case 'P':
                    P();
                    break;
                case 'R':
                    R();
                    break;
                case 'S':
                    S();
                    break;
                case 'T':
                    T();
                    break;
                case 'U':
                    U();
                    break;
                case 'V':
                    V();
                    break;
                case 'Y':
                    Y();
                    break;
                case 'Z':
                    Z();
                    break;
                case ' ':
                    SPACE();
                    break;
                default:
                    break;
            }
        }

        static void SPACE()
        {
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }
        static void A()
        {
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void B()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void C()
        {
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void D()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX              XXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX              XXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void E()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void F()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void G()
        {
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX              XXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX    XXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX    XXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX    XXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void H()
        {
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void I()
        {
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void J()
        {
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("              XXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("          XXXXXXXXX              ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXXX                    ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXXX                    ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void K()
        {
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX            XXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX         XXXXXXXXX      ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX      XXXXXXXXX         ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX   XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX              ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXX                 ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXX                 ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX   XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX      XXXXXXXXX         ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX         XXXXXXXXX      ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX            XXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void L()
        {
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void M()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX                     XXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX                    XXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX                   XXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX  XXXXXXXXX                 XXXXXXXXX  XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX   XXXXXXXXX               XXXXXXXXX   XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX    XXXXXXXXX             XXXXXXXXX    XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX     XXXXXXXXX           XXXXXXXXX     XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX      XXXXXXXXX         XXXXXXXXX      XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX       XXXXXXXXX       XXXXXXXXX       XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX        XXXXXXXXXX    XXXXXXXXXX       XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX         XXXXXXXXXXXXXXXXXXXXXX        XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX          XXXXXXXXXXXXXXXXXXXX         XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX           XXXXXXXXXXXXXXXXXX          XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void N()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX         XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX         XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXX         XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX  XXXXXXXXX        XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX   XXXXXXXXX       XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX    XXXXXXXXX      XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX     XXXXXXXXX     XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX      XXXXXXXXX    XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX       XXXXXXXXX   XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX        XXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX         XXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX          XXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX           XXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void O()
        {
            Console.WriteLine("     XXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXX             XXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXX             XXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("     XXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void P()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX                        ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void R()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX   XXXXXXXXXXX          ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX     XXXXXXXXXX         ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX       XXXXXXXXXX       ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX         XXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX           XXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX             XXXXXXXXXX ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void S()
        {
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXX             XXXXXXXXXX ");
            Thread.Sleep(t);
            Console.WriteLine("  XXXXXXXXX             XXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("    XXXXXXXXX                     ");
            Thread.Sleep(t);
            Console.WriteLine("       XXXXXXXXX                  ");
            Thread.Sleep(t);
            Console.WriteLine("          XXXXXXXXXX              ");
            Thread.Sleep(t);
            Console.WriteLine("             XXXXXXXXXX           ");
            Thread.Sleep(t);
            Console.WriteLine("                XXXXXXXXXX        ");
            Thread.Sleep(t);
            Console.WriteLine("                    XXXXXXXXXX    ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXX             XXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine(" XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void T()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void U()
        {
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("  XXXXXXXXXXXXXXXXXXXXXXXXXXXX  ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void V()
        {
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine(" XXXXXXXXX             XXXXXXXXX ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXX          XXXXXXXXX  ");
            Thread.Sleep(t);
            Console.WriteLine("      XXXXXXXXXXXXXXXXXXXXXX     ");
            Thread.Sleep(t);
            Console.WriteLine("        XXXXXXXXXXXXXXXXX        ");
            Thread.Sleep(t);
            Console.WriteLine("           XXXXXXXXXXX           ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void Y()
        {
            Console.WriteLine("XXXXXXXXX               XXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("  XXXXXXXXX           XXXXXXXXX  ");
            Thread.Sleep(t);
            Console.WriteLine("    XXXXXXXXX       XXXXXXXXX    ");
            Thread.Sleep(t);
            Console.WriteLine("      XXXXXXXXX   XXXXXXXXX      ");
            Thread.Sleep(t);
            Console.WriteLine("         XXXXXXX XXXXXXX        ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static void Z()
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("                     XXXXXXXXX   ");
            Thread.Sleep(t);
            Console.WriteLine("                  XXXXXXXXX      ");
            Thread.Sleep(t);
            Console.WriteLine("               XXXXXXXXX         ");
            Thread.Sleep(t);
            Console.WriteLine("            XXXXXXXXX            ");
            Thread.Sleep(t);
            Console.WriteLine("         XXXXXXXXX               ");
            Thread.Sleep(t);
            Console.WriteLine("      XXXXXXXXX                  ");
            Thread.Sleep(t);
            Console.WriteLine("   XXXXXXXXX                     ");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Thread.Sleep(t);
            Console.WriteLine("");
            Thread.Sleep(t);
            Console.WriteLine("");
        }

        static string space(int i)
        {
            string result = string.Empty;
            for (int x = 0; x < i; x++)
                result += " ";
            return result;
        }
    }
}
