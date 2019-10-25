using System;

namespace Interfaces{
    public class RubberDuck : Duck{
        public  override void display(){
            Console.WriteLine("Pato de borracha!!");
        }
        public override void quack(){
            Console.WriteLine("Bipppp");
        }

    }
}