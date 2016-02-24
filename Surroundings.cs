using System.Collections.Generic;
using System;


namespace Escape
{
    public class Surroundings
    {
        public static string move(int a , List<int> HW, List<int> VW, List<int> Torch, List<int> Exit)
        {
            
            var HWexists = HW.Contains(a);
            var VWexists = VW.Contains(a);
            var Torchexists = Torch.Contains(a);
            var Exitexists = Exit.Contains(a);

            if ( HWexists == true)
            {
                return "_";
            }
            if (VWexists == true)
            {
                return "|";
            }
            if (Torchexists == true)
            {
                return "Y";
            }
            if (Exitexists == true)
            {
                return "O";
            }

            else return " ";
        }
    }

}
