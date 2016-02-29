using ConsoleApplication4;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace Escape
{
    class Program
    {
        static void Main(string[] args)
        {
            #region <Object Coords> 

            List<int> HW = new List<int>
            {

            095101, 076100, 081098, 081097, 091091, 077087, 079082, 095068, 095067, 082057, 093047, 084043, 073039,
            075039, 096101, 077100, 088097, 080093, 092091, 078087, 080082, 091064, 083065, 083057, 094047, 085043,
            074039, 097101, 078100, 089097, 081093, 093091, 079087, 081082, 092064, 084065, 085057, 095047, 086043,
            075054, 093100, 089063, 075045, 094071, 073061, 094100, 091058, 080046, 095045, 095071, 102047, 090039,
            096045, 103047, 091039, 101101, 082100, 093094, 085093, 094089, 085082, 096064, 076059, 089053, 098039,
            101050, 090043, 079039, 082039, 098101, 079100, 090097, 082093, 094091, 080087, 082082, 093064, 085065,
            086057, 097050, 087043, 076039, 078039, 099101, 080100, 091097, 083093, 095091, 081087, 083082, 094064,
            086065, 090059, 099050, 088043, 077039, 100101, 081100, 091096, 084093, 085090, 093089, 084082, 095064,
            075059, 091059, 100050, 089043, 102101, 083100, 094094, 086093, 076085, 095089, 086082, 097064, 077059,
            090053, 091043, 080039, 103101, 084100, 095094, 095080, 079063, 078059, 091053, 097047, 096039, 097039,
            092043, 081039, 104101, 085100, 096094, 088093, 078085, 083084, 096080, 080063, 079059, 086045, 095039,
            075041, 093043, 075080, 087100, 080085, 085084, 088045, 078041, 095043, 092039, 093039, 094039, 089039,
            084039, 105101, 086100, 097094, 089093, 079085, 084084, 097080, 081063, 080059, 087045, 077041, 094043,
            083039, 093077, 088100, 093075, 091073, 089071, 086084, 085062, 090045, 079041, 096043, 085039, 104047,
            095077, 090100, 093073, 091071, 090069, 079054, 081041, 099047, 087039, 094077, 089100, 096071, 097071,
            094075, 092073, 090071, 089069, 077065, 086062, 091045, 080041, 086039, 096077, 091100, 094073,
            092071, 071061, 090058, 080054, 093045, 082041, 088039, 092100, 071054, 095073, 093071, 072061, 104050,
            079046, 094045, 101047, 103096, 104096, 103050, 104050, 100045};

            List<int> VW = new List<int>
            {

            105100, 105099, 105098, 105097, 102096, 102095, 102094, 102093, 102092, 102091, 102090, 102089, 102088,
            102087, 102086, 102085, 102084, 102083, 102082, 102081, 102080, 102079, 102078, 102077, 102076, 102075,
            102074, 102073, 102072, 102071, 102070, 102069, 102068, 102067, 102066, 102065, 102064, 102063, 102062,
            102061, 102060, 102059, 102058, 102057, 102056, 102055, 102054, 102053, 102052, 102051, 102050, 101046,
            099046, 099045, 099044, 099043, 099042, 099041, 099040, 099039, 098096, 098095, 098094, 098093, 098092,
            098091, 098090, 098089, 098088, 098087, 098086, 098085, 098084, 098083, 098082, 098081, 098080, 098079,
            098078, 098077, 098076, 098075, 098074, 098073, 098072, 098071, 098070, 098069, 098068, 098067, 098066,
            098065, 098064, 098063, 098062, 098061, 098060, 098059, 098058, 098057, 098056, 098055, 098054, 098053,
            098052, 098051, 098050, 097046, 097045, 097044, 096059, 096058, 096057, 096056, 096055, 096054, 096053,
            096052, 096051, 096050, 096049, 096048, 096047, 096067, 096090, 096089, 096088, 096087, 096086, 096085,
            096084, 096083, 096082, 095100, 095099, 095098, 095097, 095076, 094063, 094062, 094061, 094060, 094059,
            094058, 094057, 094056, 094055, 094054, 094053, 094052, 094051, 094050, 094067, 094087, 094086, 094085,
            094084, 094083, 094082, 094081, 094080, 092096, 092095, 092094, 092090, 092089, 092088, 092087, 092086,
            092085, 092084, 092083, 092082, 092081, 092080, 092079, 092078, 092077, 092076, 092075, 092070, 092069,
            092068, 092067, 092066, 092058, 092052, 092051, 092050, 092049, 092048, 092047, 092046, 090096, 090092,
            090091, 090087, 090086, 090085, 090084, 090083, 090082, 090081, 090080, 090079, 090078, 090077, 090076,
            090075, 090074, 090073, 090068, 090067, 090066, 090065, 090064, 090063, 089047, 089046, 089045, 089058,
            088088, 088087, 088086, 088085, 088084, 088083, 088082, 088081, 088080, 088079, 088078, 088077, 088076,
            088075, 088074, 088073, 088072, 088071, 088069, 088068, 088067, 088066, 088065, 087061, 087060, 087059,
            087058, 087057, 087056, 087055, 087054, 087053, 087052, 087051, 087050, 087096, 087095, 087094, 086092,
            086091, 085055, 085054, 085053, 085052, 085051, 085050, 085049, 085048, 085047, 085046, 085045, 082065,
            084092, 084091, 084090, 084089, 084088, 084061, 084060, 084059, 084058, 084057, 083056, 083055, 074054,
            083054, 083053, 083052, 083051, 083050, 083049, 083048, 083047, 083046, 083045, 083044, 083043, 082097,
            082086, 082085, 082064, 082063, 082062, 082061, 082060, 082059, 081053, 081052, 081051, 082084, 096091,
            081050, 081049, 081048, 081047, 081046, 080097, 079092, 079091, 079090, 078082, 078081, 095075, 090093,
            078080, 078079, 078078, 078077, 078076, 078075, 078074, 078073, 078072, 078071, 078070, 078069, 078068,
            078067, 078066, 078065, 078064, 078063, 078053, 078052, 078051, 078050, 078049, 078048, 078047, 078046,
            076045, 076044, 076043, 076042, 076041, 076058, 076057, 076056, 076055, 076054, 076084, 076083, 076082,
            076081, 076080, 076079, 076078, 076077, 076076, 076075, 076074, 076073, 076072, 076071, 076070, 076069,
            076068, 076067, 076066, 076065, 076099, 076098, 076097, 076096, 076095, 076094, 076093, 076092, 076091,
            076090, 076089, 076088, 076087, 074078, 074077, 074076, 074075, 074074, 074073, 074072, 074071, 074070,
            074069, 074068, 074067, 074066, 074065, 074064, 074063, 074062, 074061, 074060, 074059, 074053, 074052,
            074051, 074050, 074049, 074048, 074047, 074046, 074045, 074044, 074043, 074042, 072053, 072052, 072051,
            072050, 072049, 072048, 072047, 072046, 072045, 072044, 072043, 072042, 072041, 072040, 072039, 070060,
            070059, 070058, 070057, 070056, 070055, 070054, 087093, 079093, 077086, 077085, 074079, 070061, 072054,
            074041, 092045, 086090, 105096, 105049, 105048, 105047, 101047, 097043,};

            List<int> Torch = new List<int>
            { 077042, 075064, 079066, 083092, 086061, 091046, 097072, 096099, 091095};

            List<int> Exit = new List<int>
            { 100046 };

            #endregion

            int trys = 1;

            Title.title();

            START:;

             MySettings settings = MySettings.Load();

            int player = settings.MyNumber;
            int x = 50;
            int heatpack = 3;

            Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);


            NEXTMOVE:;

            System.ConsoleKey key = System.ConsoleKey.B;

            key = Console.ReadKey(true).Key;


            while (x != 0)
            {

                #region <Invalid Key pushed>
                 if (key != System.ConsoleKey.DownArrow
                    && key != System.ConsoleKey.UpArrow
                    && key != System.ConsoleKey.LeftArrow
                    && key != System.ConsoleKey.RightArrow
                    && key != System.ConsoleKey.Q
                    && Convert.ToChar(key) != Convert.ToChar("q")
                    && key != System.ConsoleKey.B
                    && key == System.ConsoleKey.H
                    && Convert.ToChar(key) == Convert.ToChar("h"))  

                {
                    goto NEXTMOVE;
                }
                #endregion

                #region <Heat Pack>

                if ((key == System.ConsoleKey.H || Convert.ToChar(key) == Convert.ToChar("h")) && heatpack != 0)

                {
                    Console.Clear();
                    heatpack --;
                    x = 50;
                    Move.move(player, x, 1, heatpack, HW, VW, Torch, Exit);
                    goto NEXTMOVE;
                }

                if ((key == System.ConsoleKey.H || Convert.ToChar(key) == Convert.ToChar("h")) && heatpack == 0)
                {
                    goto NEXTMOVE;
                }
                    #endregion

                #region <Move Down> 

                    if (key == System.ConsoleKey.DownArrow)

                {
                    Console.Clear();
                    x--;
                    player = player - 1;
                    var HWexists = HW.Contains(player);
                    var VWexists = VW.Contains(player);
                    var Torchexists = Torch.Contains(player);
                    var Exitexists = Exit.Contains(player);

                    if (HWexists == true || VWexists == true)
                    {
                        player = player + 1;
                        settings.Save();
                        x += 1;
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    if (Torchexists == true)
                    {
                        x = 50;
                        settings.Save();
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    if (Exitexists == true)
                    {
                        settings.Save();
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto WON;
                    }

                    else
                    settings.Save();
                    Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                    goto NEXTMOVE;
                }

                #endregion

                #region <Move Left> 

                if (key == System.ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    x--;
                    player = player - 1000;
                    var HWexists = HW.Contains(player);
                    var VWexists = VW.Contains(player);
                    var Torchexists = Torch.Contains(player);

                    if (HWexists == true || VWexists == true)
                    {
                        player = player + 1000;
                        settings.Save();
                        x += 1;
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    if (Torchexists == true)
                    {
                        x = 50;
                        settings.Save();
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    else
                        settings.Save();
                    Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                    goto NEXTMOVE;
                }
                #endregion

                #region <Move Up> 

                if (key == System.ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    x--;
                    player = player + 1;
                    var HWexists = HW.Contains(player);
                    var VWexists = VW.Contains(player);
                    var Torchexists = Torch.Contains(player);

                    if (HWexists == true || VWexists == true)
                    {
                        player = player -1;
                        settings.Save();
                        x += 1;
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    if (Torchexists == true)
                    {
                        x = 50;
                        settings.Save();
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    else
                        settings.Save();
                    Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                    goto NEXTMOVE;
                }
                #endregion

                #region <Move Right>

                if (key == System.ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    x--;
                    player = player + 1000;
                    var HWexists = HW.Contains(player);
                    var VWexists = VW.Contains(player);
                    var Torchexists = Torch.Contains(player);

                    if (HWexists == true || VWexists == true)
                    {
                        player = player - 1000;
                        settings.Save();
                        x += 1;
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    if (Torchexists == true)
                    {
                        x = 50;
                        settings.Save();
                        Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                        goto NEXTMOVE;
                    }
                    else
                        settings.Save();
                    Move.move(player, x, 0, heatpack, HW, VW, Torch, Exit);
                    goto NEXTMOVE;

                  }
                #endregion

                #region <Quit Premature>

                if (key == System.ConsoleKey.Q || Convert.ToChar(key) == Convert.ToChar("q"))
                {
                    Console.WriteLine("Quitting, Thanks for playing!");
                    Console.WriteLine("");
                    goto END;
                }

                #endregion

            }

                #region <Froze>

            Console.WriteLine("You Froze!  Press r to retry or q to quit ");
            

            int v = 1;
            
            while (2 != v)
            {

                INVAILDKEY:;

                System.ConsoleKey key2 = System.ConsoleKey.B;

                key2 = Console.ReadKey(true).Key;

                
                if (    Convert.ToChar(key2) != Convert.ToChar("q")
                    &&  Convert.ToChar(key2) != Convert.ToChar("r")
                    &&  key2 != System.ConsoleKey.R
                    &&  key2 != System.ConsoleKey.Q
                    &&  key2 != System.ConsoleKey.B)
                {
                    goto INVAILDKEY;
                }

                if (key2 == System.ConsoleKey.R || Convert.ToChar(key2) == Convert.ToChar("r"))
                {
                    Console.Clear();
                    player = 100100;
                    trys++;
                    goto START;
                }
                if (key2 == System.ConsoleKey.Q || Convert.ToChar(key2) == Convert.ToChar("q"))
                {

                    Console.WriteLine("");
                    Console.WriteLine("Quitting, Thanks for playing!");
                    Console.WriteLine("");
                    goto END;
                }
             
            }

        #endregion

                #region <Won>
                
        WON:;

            Console.WriteLine("You've made it! Well Done!");
            Console.WriteLine("You found the exit in {0} attempts, with {1} steps left!", trys, x);
            Console.WriteLine("");
            Console.WriteLine("press r to retry or q to quit");
            int w = 1;

            while (2 != w)
            {


                INVAILDKEY2:;

                System.ConsoleKey key3 = System.ConsoleKey.B;

                key3 = Console.ReadKey(true).Key;


                if  (Convert.ToChar(key3) != Convert.ToChar("q")
                    && Convert.ToChar(key3) != Convert.ToChar("r")
                    && key3 != System.ConsoleKey.R
                    && key3 != System.ConsoleKey.Q
                    && key3 != System.ConsoleKey.B)
                {
                    goto INVAILDKEY2;
                }

                if (key3 == System.ConsoleKey.R || Convert.ToChar(key3) == Convert.ToChar("r"))
                {
                    Console.Clear();
                    player = 100100;
                    trys = 0;
                    goto START;
                }
                if (key3 == System.ConsoleKey.Q || Convert.ToChar(key3) == Convert.ToChar("q"))
                {

                    Console.WriteLine("");
                    Console.WriteLine("Quitting, Thanks for playing!");
                    Console.WriteLine("");
                    goto END;
                }
            }

        #endregion


           END:;

           Thread.Sleep(2300);
        } 
    }
}
