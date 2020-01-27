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
        public Band()
        {

        }
        #region Constructor

        public Band(string name, int formed, string members)
        {
            Name = name;
            Formed = formed;
            Members = members;
        }



        #endregion Constructor
        public override string ToString()
        {
            return (this.Name + Formed + Members);
        }

    }
    public class RockBand : Band
    {
        public RockBand(string name, int formed, string members)
        {
            Name = name;
            Formed = formed;
            Members = members;
        }


        public override string ToString()
        {
            return (this.Name + " - rock Band");
        }


    }

    public class IndieBand : Band
    {
        public IndieBand(string name, int formed, string members)
        {
            Name = name;
            Formed = formed;
            Members = members;
        }
        public override string ToString()
        {
            return (this.Name + " - rock Band");
        }
    }
    public class PopBand : Band
    {
        public PopBand(string name, int formed, string members)
        {
            Name = name;
            Formed = formed;
            Members = members;
        }
        public override string ToString()
        {
            return (this.Name + " - rock Band");
        }

    }
}
