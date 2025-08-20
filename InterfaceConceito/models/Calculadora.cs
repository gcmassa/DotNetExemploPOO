using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceConceito.Interfaces;

namespace InterfaceConceito.models
{
    public class Calculadora : ICalculadora //Calculadora implementa a ICalculadora <No VSCODE caso Icalculadora esteja sublunhado de vermelho clicar em cima e em seguida pressionar a telca Ctrl e . para aparecer opcao de implementar>
    {
        public int Dividir(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 - num2;
        }
    }
}