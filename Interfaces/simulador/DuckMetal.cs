using System;

namespace Interfaces
{
    public class DuckMetal : Duck, IQuackable
    {

        public override void display()
        {
            Console.WriteLine("Pato de METALLL!!!");
        }

        public override void quack()
        {
            Console.WriteLine("Quaa qua quaack");
        }

    }

}