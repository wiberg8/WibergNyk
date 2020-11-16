using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WibergNykLibary;

namespace WibergNykLibary
{
    public class Nyckel
    {
        public Nyckel()
        {

        }

        public Nyckel(int id)
        {
            this.ID = id;
            this.Typ = string.Empty;
            this.Serie = string.Empty;
            this.Nummer = string.Empty;
            this.Ovrigt = string.Empty;
        }

        #region Properties
        public int ID { get; set; }
        public string Typ { get; set; }
        public string Serie { get; set; }
        public string Nummer {get;set;}
        public string Ovrigt { get; set; }
        public NyckelStatus Status { get; set; }
        public int PersoId { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"{this.ID} {this.Typ} {this.Serie} {this.Nummer}";
        }
        #endregion
    }
}
