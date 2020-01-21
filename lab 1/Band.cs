using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public abstract class Band
    {
        #region props

        public string Name { get; set; }

        public int Formed { get; set; }
        public string Members {get; set; }


        #endregion props

        #region Constructor
        public Band(string name, int formed, string members )
        {
            Name = name;
            Formed = formed;
            Members = members;
        }




        #endregion Constructor


    }
    //public class RockBand : Band
    //{

    //}
}
