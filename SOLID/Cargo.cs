using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public abstract class Cargo 
    {
        public IRegraCalcula Regra { get; set; }
        public Cargo(IRegraCalcula regraCalcula)
        {
            this.Regra = regraCalcula;
        }

    }
}
