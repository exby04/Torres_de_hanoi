using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torres_de_Hanoi;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private List<Disco> Elementos = new List<Disco>();

        public int Size { get { return Elementos.Count; } }

        public Pila()
        {
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
        }

        public Disco pop()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            Disco disco = Elementos[Elementos.Count - 1];
            Elementos.RemoveAt(Elementos.Count - 1);
            return disco;
        }

        public bool isEmpty()
        {
            return Elementos.Count == 0;
        }

        public Disco get_top()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            return Elementos[Elementos.Count - 1];
        }
    }
}