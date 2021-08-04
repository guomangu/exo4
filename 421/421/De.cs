using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421
{
    public class De
    {
        private int faceDe;

        public int UNfaceDe { get => faceDe; set => faceDe = value; }

        public De(){
            
        }

      

        public void jeter()
        {
            Alea hasard = Alea.Instance();
            this.UNfaceDe = hasard.Next(1, 6);
        }

        public override string ToString()
        {
            return "le dé vaut " + UNfaceDe;
        }
    }
}
