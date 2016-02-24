using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape
{
    class Move
    {
        public static void move(int player, int moves, List<int> HW, List<int> VW, List<int> Torch, List<int> Exit)
        {


            // First Line
            int a1 = (player + 3) - 2000;
            int a2 = (player + 3) - 1000;
            int a3 = (player + 3);
            int a4 = (player + 3) + 1000;
            int a5 = (player + 3) + 2000;

            string A1 = Surroundings.move(a1, HW, VW, Torch, Exit);
            string A2 = Surroundings.move(a2, HW, VW, Torch, Exit);
            string A3 = Surroundings.move(a3, HW, VW, Torch, Exit);
            string A4 = Surroundings.move(a4, HW, VW, Torch, Exit);
            string A5 = Surroundings.move(a5, HW, VW, Torch, Exit);

            //Second Line
            int b1 = (player + 2) - 5000;
            int b2 = (player + 2) - 4000;
            int b3 = (player + 2) - 3000;
            int b4 = (player + 2) - 2000;
            int b5 = (player + 2) - 1000;
            int b6 = (player + 2);
            int b7 = (player + 2) + 1000;
            int b8 = (player + 2) + 2000;
            int b9 = (player + 2) + 3000;
            int b10 = (player + 2) + 4000;
            int b11 = (player + 2) + 5000;

            string B1 = Surroundings.move(b1, HW, VW, Torch, Exit);
            string B2 = Surroundings.move(b2, HW, VW, Torch, Exit);
            string B3 = Surroundings.move(b3, HW, VW, Torch, Exit);
            string B4 = Surroundings.move(b4, HW, VW, Torch, Exit);
            string B5 = Surroundings.move(b5, HW, VW, Torch, Exit);
            string B6 = Surroundings.move(b6, HW, VW, Torch, Exit);
            string B7 = Surroundings.move(b7, HW, VW, Torch, Exit);
            string B8 = Surroundings.move(b8, HW, VW, Torch, Exit);
            string B9 = Surroundings.move(b9, HW, VW, Torch, Exit);
            string B10 = Surroundings.move(b10, HW, VW, Torch, Exit);
            string B11 = Surroundings.move(b11, HW, VW, Torch, Exit);

            //Third Line
            int c1 = (player + 1) - 7000;
            int c2 = (player + 1) - 6000;
            int c3 = (player + 1) - 5000;
            int c4 = (player + 1) - 4000;
            int c5 = (player + 1) - 3000;
            int c6 = (player + 1) - 2000;
            int c7 = (player + 1) - 1000;
            int c8 = (player + 1);
            int c9 = (player + 1) + 1000;
            int c10 = (player + 1) + 2000;
            int c11 = (player + 1) + 3000;
            int c12 = (player + 1) + 4000;
            int c13 = (player + 1) + 5000;
            int c14 = (player + 1) + 6000;
            int c15 = (player + 1) + 7000;

            string C1 = Surroundings.move(c1, HW, VW, Torch, Exit);
            string C2 = Surroundings.move(c2, HW, VW, Torch, Exit);
            string C3 = Surroundings.move(c3, HW, VW, Torch, Exit);
            string C4 = Surroundings.move(c4, HW, VW, Torch, Exit);
            string C5 = Surroundings.move(c5, HW, VW, Torch, Exit);
            string C6 = Surroundings.move(c6, HW, VW, Torch, Exit);
            string C7 = Surroundings.move(c7, HW, VW, Torch, Exit);
            string C8 = Surroundings.move(c8, HW, VW, Torch, Exit);
            string C9 = Surroundings.move(c9, HW, VW, Torch, Exit);
            string C10 = Surroundings.move(c10, HW, VW, Torch, Exit);
            string C11 = Surroundings.move(c11, HW, VW, Torch, Exit);
            string C12 = Surroundings.move(c12, HW, VW, Torch, Exit);
            string C13 = Surroundings.move(c13, HW, VW, Torch, Exit);
            string C14 = Surroundings.move(c14, HW, VW, Torch, Exit);
            string C15 = Surroundings.move(c15, HW, VW, Torch, Exit);

            //Fourth Line
            int d1 = (player) - 8000;
            int d2 = (player) - 7000;
            int d3 = (player) - 6000;
            int d4 = (player) - 5000;
            int d5 = (player) - 4000;
            int d6 = (player) - 3000;
            int d7 = (player) - 2000;
            int d8 = (player) - 1000;
            int d9 = (player) + 1000;
            int d10 = (player) + 2000;
            int d11 = (player) + 3000;
            int d12 = (player) + 4000;
            int d13 = (player) + 5000;
            int d14 = (player) + 6000;
            int d15 = (player) + 7000;
            int d16 = (player) + 8000;

            string D1 = Surroundings.move(d1, HW, VW, Torch, Exit);
            string D2 = Surroundings.move(d2, HW, VW, Torch, Exit);
            string D3 = Surroundings.move(d3, HW, VW, Torch, Exit);
            string D4 = Surroundings.move(d4, HW, VW, Torch, Exit);
            string D5 = Surroundings.move(d5, HW, VW, Torch, Exit);
            string D6 = Surroundings.move(d6, HW, VW, Torch, Exit);
            string D7 = Surroundings.move(d7, HW, VW, Torch, Exit);
            string D8 = Surroundings.move(d8, HW, VW, Torch, Exit);
            string D9 = Surroundings.move(d9, HW, VW, Torch, Exit);
            string D10 = Surroundings.move(d10, HW, VW, Torch, Exit);
            string D11 = Surroundings.move(d11, HW, VW, Torch, Exit);
            string D12 = Surroundings.move(d12, HW, VW, Torch, Exit);
            string D13 = Surroundings.move(d13, HW, VW, Torch, Exit);
            string D14 = Surroundings.move(d14, HW, VW, Torch, Exit);
            string D15 = Surroundings.move(d15, HW, VW, Torch, Exit);
            string D16 = Surroundings.move(d16, HW, VW, Torch, Exit);

            //Fifth Line
            int e1 = (player - 1) - 8000;
            int e2 = (player - 1) - 7000;
            int e3 = (player - 1) - 6000;
            int e4 = (player - 1) - 5000;
            int e5 = (player - 1) - 4000;
            int e6 = (player - 1) - 3000;
            int e7 = (player - 1) - 2000;
            int e8 = (player - 1) - 1000;
            int e9 = (player - 1);
            int e10 = (player - 1) + 1000;
            int e11 = (player - 1) + 2000;
            int e12 = (player - 1) + 3000;
            int e13 = (player - 1) + 4000;
            int e14 = (player - 1) + 5000;
            int e15 = (player - 1) + 6000;
            int e16 = (player - 1) + 7000;
            int e17 = (player - 1) + 8000;

            string E1 = Surroundings.move(e1, HW, VW, Torch, Exit);
            string E2 = Surroundings.move(e2, HW, VW, Torch, Exit);
            string E3 = Surroundings.move(e3, HW, VW, Torch, Exit);
            string E4 = Surroundings.move(e4, HW, VW, Torch, Exit);
            string E5 = Surroundings.move(e5, HW, VW, Torch, Exit);
            string E6 = Surroundings.move(e6, HW, VW, Torch, Exit);
            string E7 = Surroundings.move(e7, HW, VW, Torch, Exit);
            string E8 = Surroundings.move(e8, HW, VW, Torch, Exit);
            string E9 = Surroundings.move(e9, HW, VW, Torch, Exit);
            string E10 = Surroundings.move(e10, HW, VW, Torch, Exit);
            string E11 = Surroundings.move(e11, HW, VW, Torch, Exit);
            string E12 = Surroundings.move(e12, HW, VW, Torch, Exit);
            string E13 = Surroundings.move(e13, HW, VW, Torch, Exit);
            string E14 = Surroundings.move(e14, HW, VW, Torch, Exit);
            string E15 = Surroundings.move(e15, HW, VW, Torch, Exit);
            string E16 = Surroundings.move(e16, HW, VW, Torch, Exit);
            string E17 = Surroundings.move(e17, HW, VW, Torch, Exit);

            //Sixth Line
            int f1 = (player - 2) - 7000;
            int f2 = (player - 2) - 6000;
            int f3 = (player - 2) - 5000;
            int f4 = (player - 2) - 4000;
            int f5 = (player - 2) - 3000;
            int f6 = (player - 2) - 2000;
            int f7 = (player - 2) - 1000;
            int f8 = (player - 2);
            int f9 = (player - 2) + 1000;
            int f10 = (player - 2) + 2000;
            int f11 = (player - 2) + 3000;
            int f12 = (player - 2) + 4000;
            int f13 = (player - 2) + 5000;
            int f14 = (player - 2) + 6000;
            int f15 = (player - 2) + 7000;

            string F1 = Surroundings.move(f1, HW, VW, Torch, Exit);
            string F2 = Surroundings.move(f2, HW, VW, Torch, Exit);
            string F3 = Surroundings.move(f3, HW, VW, Torch, Exit);
            string F4 = Surroundings.move(f4, HW, VW, Torch, Exit);
            string F5 = Surroundings.move(f5, HW, VW, Torch, Exit);
            string F6 = Surroundings.move(f6, HW, VW, Torch, Exit);
            string F7 = Surroundings.move(f7, HW, VW, Torch, Exit);
            string F8 = Surroundings.move(f8, HW, VW, Torch, Exit);
            string F9 = Surroundings.move(f9, HW, VW, Torch, Exit);
            string F10 = Surroundings.move(f10, HW, VW, Torch, Exit);
            string F11 = Surroundings.move(f11, HW, VW, Torch, Exit);
            string F12 = Surroundings.move(f12, HW, VW, Torch, Exit);
            string F13 = Surroundings.move(f13, HW, VW, Torch, Exit);
            string F14 = Surroundings.move(f14, HW, VW, Torch, Exit);
            string F15 = Surroundings.move(f15, HW, VW, Torch, Exit);

            //Seventh Line
            int g1 = (player - 3) - 5000;
            int g2 = (player - 3) - 4000;
            int g3 = (player - 3) - 3000;
            int g4 = (player - 3) - 2000;
            int g5 = (player - 3) - 1000;
            int g6 = (player - 3);
            int g7 = (player - 3) + 1000;
            int g8 = (player - 3) + 2000;
            int g9 = (player - 3) + 3000;
            int g10 = (player - 3) + 4000;
            int g11 = (player - 3) + 5000;

            string G1 = Surroundings.move(g1, HW, VW, Torch, Exit);
            string G2 = Surroundings.move(g2, HW, VW, Torch, Exit);
            string G3 = Surroundings.move(g3, HW, VW, Torch, Exit);
            string G4 = Surroundings.move(g4, HW, VW, Torch, Exit);
            string G5 = Surroundings.move(g5, HW, VW, Torch, Exit);
            string G6 = Surroundings.move(g6, HW, VW, Torch, Exit);
            string G7 = Surroundings.move(g7, HW, VW, Torch, Exit);
            string G8 = Surroundings.move(g8, HW, VW, Torch, Exit);
            string G9 = Surroundings.move(g9, HW, VW, Torch, Exit);
            string G10 = Surroundings.move(g10, HW, VW, Torch, Exit);
            string G11 = Surroundings.move(g11, HW, VW, Torch, Exit);

            // Eighth Line
            int h1 = (player - 4) - 2000;
            int h2 = (player - 4) - 1000;
            int h3 = (player - 4);
            int h4 = (player - 4) + 1000;
            int h5 = (player - 4) + 2000;

            string H1 = Surroundings.move(h1, HW, VW, Torch, Exit);
            string H2 = Surroundings.move(h2, HW, VW, Torch, Exit);
            string H3 = Surroundings.move(h3, HW, VW, Torch, Exit);
            string H4 = Surroundings.move(h4, HW, VW, Torch, Exit);
            string H5 = Surroundings.move(h5, HW, VW, Torch, Exit);


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"| ___|/ ___| /  __|/  _  \ /  __ || ___| | |");
            Console.WriteLine(@"| |__ | \__ |  /   | |_| | | |_| || |__  | |");
            Console.WriteLine(@"| ___| \__ \| |    |  __ | |  __/ | ___| |_|");
            Console.WriteLine(@"| |__  __/ ||  \__ | | | | | |    | |__   _ ");
            Console.WriteLine(@"|____||___/  \____||_| |_| |_|    |____| |_|");
            Console.WriteLine(" ");
            Console.WriteLine("You've awoken in a dark room, it's absolutely freezing!");
            Console.WriteLine("Find the exit quick before you freeze!");
            Console.WriteLine("                         ");
            Console.WriteLine("< Move using a,w,s,d  or quit using q                      >");
            Console.WriteLine("< Use torches Y to keep you warm while you find the exit O >");
            Console.WriteLine("                         ");
            Console.WriteLine("{0} Steps till freeze", moves);
            Console.WriteLine("                      ");
            
            Console.WriteLine("          {0}{1}{2}{3}{4}          ", A1, A2, A3, A4, A5);
            Console.WriteLine("       {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}       ", B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11);
            Console.WriteLine("     {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}     ", C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15);
            Console.WriteLine("    {0}{1}{2}{3}{4}{5}{6}{7}@{8}{9}{10}{11}{12}{13}{14}{15}    ", D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16);
            Console.WriteLine("    {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}    ", E1, E2, E3, E4, E5, E6, E7, E8, E9, E10, E11, E12, E13, E14, E15, E16, E17);
            Console.WriteLine(@"     {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}     ", F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13, F14, F15);
            Console.WriteLine(@"       {0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}       ", G1, G2, G3, G4, G5, G6, G7, G8, G9, G10, G11);
            Console.WriteLine(@"          {0}{1}{2}{3}{4}          ", H1, H2, H3, H4, H5);
            Console.WriteLine("                        ");
        }
    }
}

