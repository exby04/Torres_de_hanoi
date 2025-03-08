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
        public void imprimir(Pila ini, Pila aux, Pila fin)
        {

            Console.Write("Torre INI: "); imprimirPila(ini);
            Console.Write("\n");
            Console.Write("Torre AUX: "); imprimirPila(aux);
            Console.Write("\n");
            Console.Write("Torre FIN: "); imprimirPila(fin);
            Console.Write("\n");
            Console.Write("\n");
        }
        public void imprimirPila(Pila p)
        {
            foreach (Disco disco in p.Elementos)
            {
                Console.Write(disco.NUM + " ");
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int totalMovimientos = (int)Math.Pow(2,n) - 1;
            int m = 0;

            if(n % 2 != 0)
            {
                while (fin.Size != n){
                    mover_disco(ini, fin);
                    m++;
                    imprimir(ini, aux, fin);
                    
                    mover_disco(ini, aux);
                    m++;
                    imprimir(ini, aux, fin);

                    mover_disco(aux, fin);
                    m++;
                    imprimir(ini, aux, fin);
                    
                }
            } else {
                while (aux.Size != n){
                    mover_disco(ini, aux);
                    m++;
                    mover_disco(ini, fin);
                    m++;
                    mover_disco(aux, fin);
                    m++;
                }
            }

            return m;

        }

    }
}
