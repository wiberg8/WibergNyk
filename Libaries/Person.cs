using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WibergNykLibary;

namespace WibergNykLibary
{
    public class Person
    {
        public Person()
        {

        }
        public Person(int id)
        {
            this.ID = id;
            this.Fornamn = string.Empty;
            this.Efternamn = string.Empty;
            this.PersNr = string.Empty;
            this.Telefon = string.Empty;
            this.AnstalldSom = string.Empty;
            this.Ovrigt = string.Empty;
        }

        #region Properties that set / gets values from the private fields
        public int ID { get; set; }
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string PersNr { get; set; }
        public string Telefon { get; set; }
        public string AnstalldSom { get; set; }
        public string Ovrigt { get; set; }
       
        #endregion

        #region Properties that doesnt set that doesnt represent the "direct" value of the private variables
        public string Namn
        {
            //Returns Förnamn and Efternamn concatinated with a space btw
            get { return $"{this.Fornamn} {this.Efternamn}"; }
        }
        #endregion

        #region Overides
        public override string ToString()
        {
            //Returnerar ID Förnamn och Efternamn 
            return $"{this.ID} {this.Namn}";
        }
        #endregion
    }
}
