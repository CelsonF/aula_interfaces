using System;

namespace Interfaces{
    public class ReadHeadDuck : Duck, IFlyable{
        public  override void display(){
            Console.WriteLine("Pato de cabeça Vermelha!!");
        }

        public void fly(){
            Console.WriteLine("Voar!!!");
        }
    }
}