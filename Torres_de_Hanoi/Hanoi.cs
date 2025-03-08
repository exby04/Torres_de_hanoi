using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private int movimientos = 0; // Contador de movimientos

        public void mover_disco(Pila origen, Pila destino)
        {
            if (origen.isEmpty())
            {
                throw new InvalidOperationException("La pila origen está vacía.");
            }

            Disco topOrigen = origen.get_top();

            if (!destino.isEmpty())
            {
                Disco topDestino = destino.get_top();
                if (topOrigen.NUM > topDestino.NUM)
                {
                    throw new InvalidOperationException("Movimiento inválido: el disco origen es mayor que el destino.");
                }
            }

            destino.push(origen.pop());
            movimientos++; // Incrementar el contador de movimientos
        }

        public void imprimir(Pila ini, Pila aux, Pila fin)
        {
            Console.Write("Torre INI: "); imprimirPila(ini);
            Console.Write("Torre AUX: "); imprimirPila(aux);
            Console.Write("Torre FIN: "); imprimirPila(fin);
            Console.WriteLine();
        }

        public void imprimirPila(Pila p)
        {
            foreach (Disco disco in p.Elementos)
            {
                Console.Write(disco.NUM + " ");
            }
            Console.WriteLine(); // Salto de línea después de imprimir los discos
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int totalMovimientos = (int)Math.Pow(2, n) - 1;
            int m = 0;

            // Determinar la dirección del movimiento del disco más pequeño
            bool moverDerecha = (n % 2 == 0);

            for (int i = 1; i <= totalMovimientos; i++)
            {
                if (i % 3 == 1) // Mover entre INI y FIN
                {
                    if (moverDerecha)
                    {
                        if (!ini.isEmpty() && (fin.isEmpty() || ini.get_top().NUM < fin.get_top().NUM))
                        {
                            mover_disco(ini, fin);
                        }
                        else
                        {
                            mover_disco(fin, ini);
                        }
                    }
                    else
                    {
                        if (!ini.isEmpty() && (fin.isEmpty() || ini.get_top().NUM < fin.get_top().NUM))
                        {
                            mover_disco(ini, fin);
                        }
                        else
                        {
                            mover_disco(fin, ini);
                        }
                    }
                }
                else if (i % 3 == 2) // Mover entre INI y AUX
                {
                    if (moverDerecha)
                    {
                        if (!ini.isEmpty() && (aux.isEmpty() || ini.get_top().NUM < aux.get_top().NUM))
                        {
                            mover_disco(ini, aux);
                        }
                        else
                        {
                            mover_disco(aux, ini);
                        }
                    }
                    else
                    {
                        if (!ini.isEmpty() && (aux.isEmpty() || ini.get_top().NUM < aux.get_top().NUM))
                        {
                            mover_disco(ini, aux);
                        }
                        else
                        {
                            mover_disco(aux, ini);
                        }
                    }
                }
                else if (i % 3 == 0) // Mover entre AUX y FIN
                {
                    if (moverDerecha)
                    {
                        if (!aux.isEmpty() && (fin.isEmpty() || aux.get_top().NUM < fin.get_top().NUM))
                        {
                            mover_disco(aux, fin);
                        }
                        else
                        {
                            mover_disco(fin, aux);
                        }
                    }
                    else
                    {
                        if (!aux.isEmpty() && (fin.isEmpty() || aux.get_top().NUM < fin.get_top().NUM))
                        {
                            mover_disco(aux, fin);
                        }
                        else
                        {
                            mover_disco(fin, aux);
                        }
                    }
                }

                m++;
                imprimir(ini, aux, fin);
            }

            return m;
        }

        public int recursivo(int n, Pila origen, Pila destino, Pila auxiliar)
        {
            if (n == 1)
            {
                mover_disco(origen, destino);
                imprimir(origen, auxiliar, destino);
                return 1; // Un movimiento realizado
            }
            else
            {
                int movimientos = 0;

                // Mover n-1 discos de origen a auxiliar
                movimientos += recursivo(n - 1, origen, auxiliar, destino);

                // Mover el disco más grande de origen a destino
                mover_disco(origen, destino);
                imprimir(origen, auxiliar, destino);
                movimientos++;

                // Mover n-1 discos de auxiliar a destino
                movimientos += recursivo(n - 1, auxiliar, destino, origen);

                return movimientos;
            }
        }
    }
}