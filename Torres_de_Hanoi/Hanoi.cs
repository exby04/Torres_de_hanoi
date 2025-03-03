using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {   
            if (a.isEmpty())
            {
                return; //"La pila origen está vacía."
            }
             if (b.isEmpty())
            {
                b.push(a.pop());
                return;
            }
            if (a.get_top().NUM < b.get_top().NUM)
            {
                b.push(a.pop());
            }
            else
            {
                return; //Movimiento inválido: el disco origen es mayor que el destino.
            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
