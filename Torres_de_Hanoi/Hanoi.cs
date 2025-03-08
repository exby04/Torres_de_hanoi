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
            int totalMovimientos = (int)Math.Pow(2,n) - 1;

            if(n % 2 == 0)
            {
                Pila temp = fin;
                fin = aux;                  //Si el numero de discos es par, cambia la pila aux por la pila fin y viceversa
                aux = temp;
            }

            for(int i = n ; i >= 1 ; i--) 
            {
                ini.push(new Disco(i)); //Creamos la pila inicial.
            }

            for(int i = 1; i <= totalMovimientos; i++)
            {
                if(i % 3 == 1)
                {
                    mover_disco(ini,fin);
                }else if(i % 3 == 2)
                {
                    mover_disco(ini, aux);
                }else if(i % 3 == 0)
                {
                    mover_disco(aux,fin);
                }
            }
            return totalMovimientos;
        }

    }
}
