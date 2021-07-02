using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraCalcula regraCalcula) : 
            base(regraCalcula)
        {

        }
    }
}
