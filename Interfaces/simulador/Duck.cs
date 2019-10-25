using System;

namespace Interfaces{
public class Duck{
    public virtual void quack(){
        Console.WriteLine("quackkk!!!!");
    }
    public void swim(){
        Console.WriteLine("Nadar!!!");
    }

    public  virtual void display(){
        Console.WriteLine("Pato genérico");
        quack();
        swim();
    }

   }
}