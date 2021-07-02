using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class QuinzeOuVinteECincoPorCento : IRegraCalcula
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }
            else
            {
                return funcionario.SalarioBase * 0.85;
            }
        }
    }
}
