using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstruments
{
    public class Instrument
    {
        public bool percussion;
        public bool stringed;
        public bool woodwind;
        public bool brass;

        public Instrument()
        {
            this.percussion = false;
            this.stringed = false;
            this.woodwind = false;
            this.brass = false;
        }
    }
    public class Drums : Instrument
        {

        public int numberOfCymbals;

        public Drums()
        {
          
            this.percussion= true;
            this.stringed= false;
            this.woodwind= false;
            this.brass= false;
            this.numberOfCymbals= 0;
        }
             
    }

}

