using System;

namespace Interfaces
{
    public class DuckWood : Duck, IQuackable
    {
        public override void display() 
        {
            Console.WriteLine("Pato de Madeira");
         }
        public override void quack()
        {
            Console.WriteLine("Sem Quaaack!!!");
        }

    }

}