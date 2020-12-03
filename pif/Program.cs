using System;

namespace pif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое вертикальное число");
            int vertikal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе вертикальное число");
            int vertikal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое горизонтальное число");
            int gorizontal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе горизонтальное число");
            int gorizontal2 = int.Parse(Console.ReadLine());
            string space = " ";
            string space2 = space;
            string space3 = space;
            string spaceg = space;
            string dash = "-";
            string dashg = dash;
            string dash2 = dash;
            int gorizontal3 = gorizontal1;
            int vertikal3 = vertikal1;
            int max = vertikal2 * gorizontal2;
            int min = vertikal1 * gorizontal1;
            int spaces = 0;
            int spaces2 = 0;
            int halp = 1;
            int score = 0;
            int score2 = 0;
            int max2 = max;
            int kick = 1;
            int kick2 = 1;
            int kickg = 1;
            int maxg = gorizontal2;
            int ming = gorizontal1;
            int spacesg = 0;
            int halpg = 1;
            while (maxg >= 1)
            {
                spacesg++;
                kickg = kickg * 10;
                dashg = dashg + dash2;
                spaceg = spaceg + space;
                maxg = maxg / 10;

            }
            while (ming >= 1)
            {
                halpg = halpg * 10;
                ming = ming / 10;
            }


            while (max >= 1)
            {
                spaces++;
                dash = dash + dash2;
                kick = kick * 10;
                kick2 = kick2 * 10;
                max = max / 10;
            }
            kick = kick / 10;
            kick2 = kick2 / 10;
            while (min >= 1)
            {
                spaces2++;
                min = min / 10;
                halp = halp * 10;
            }
            int halp2 = halp;
            int spa = spaces - 1;//тут было spa = spaces - spaces2
            int spa2 = spa;
            int spag = spacesg - 1;
            int spag2 = spag;
            while (gorizontal1 <= gorizontal3)
            {
                Console.Write(spaceg + "|");
                while (vertikal1 <= vertikal2)
                {
                    score2 = vertikal1 * 1;

                    while (score2 >= halp2)
                    {
                        while (score2 >= kick2)
                        {
                            spa--;
                            kick2 = kick2 * 10;
                        }
                        space = space2;
                        halp2 = halp2 * 10;

                    }

                    int final2 = score2;
                    while (final2 >= 10)
                    {
                        final2 = final2 / 10;
                        spa--;
                    }
                    space = space2;
                    while (spa >= 1)
                    {

                        space = space + space2;
                        spa--;
                    }
                    Console.Write(space + score2);
                    spa = spa2;
                    vertikal1++;
                }
                gorizontal1++;
            }
            gorizontal1 = gorizontal3;
            vertikal1 = vertikal3;
            Console.WriteLine();
            while (gorizontal1 <= gorizontal3)
            {
                Console.Write(dashg + "+");
                while (vertikal1 <= vertikal2)
                {

                    Console.Write(dash);
                    spa = spa2;
                    vertikal1++;
                }
                gorizontal1++;
            }
            gorizontal1 = gorizontal3;
            vertikal1 = vertikal3;
            Console.WriteLine();
            while (gorizontal1 <= gorizontal2)
            {


                while (gorizontal1 >= halpg)
                {
                    while (gorizontal1 >= kickg)
                    {
                        spag--;
                        kickg = kickg * 10;

                    }
                    space3 = space2;
                    halpg = halpg * 10;

                }
                int finalg = gorizontal1;
                while (finalg >= 10)
                {
                    finalg = finalg / 10;
                    spag--;
                }
                space3 = space2;
                while (spag >= 1)
                {
                    space3 = space3 + space2;
                    spag--;
                }
                Console.Write(space3 + gorizontal1 + "|");
                while (vertikal1 <= vertikal2)
                {
                    score = vertikal1 * gorizontal1;

                    while (score >= halp)
                    {
                        while (score >= kick)
                        {
                            spa--;
                            kick = kick * 10;
                        }
                        space = space2;
                        halp = halp * 10;

                    }

                    int final = score;
                    while (final >= 10)
                    {
                        final = final / 10;
                        spa--;
                    }
                    space = space2;
                    while (spa >= 1)
                    {

                        space = space + space2;
                        spa--;
                    }
                    Console.Write(space + score);
                    spa = spa2;
                    vertikal1++;
                }
                vertikal1 = vertikal3;
                Console.WriteLine();
                spag = spag2;
                gorizontal1++;


            }

        }
    }
}
