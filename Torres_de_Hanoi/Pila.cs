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
        private List<Disco> Elementos;
    
        private int Top;
        public int Size { get; set; }
        
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }       
        */
        /* TODO: Elegir tipo de Elementos
        public List<Disco> Elementos { get; set; }
        */
        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Elementos = new Arraylist<Disco>();
        }

        public void push(Disco d)
        {
            this.Elementos.add(d);
        }

        public Disco pop()
        {
            return Elementos[Elementos.count - 1]; //Mirar
        }                

        public bool isEmpty()
        {
            Elementos.Count == 0 ? return false : return true;
        }

        public int get_top(){
            return this.Elementos[Elementos.count -1];
        }
        


    }
}


Pila ini = new Pila() 
ini.push(disco1)
