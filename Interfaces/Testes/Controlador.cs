using System;

namespace Interfaces {

    public static class Controlador{
        
        public static void testar(){
            Duck pato = new Duck();
            pato.display();
            
            Duck patomau = new MallarDuck();
            patomau.display();

            ReadHeadDuck patovermelho = new ReadHeadDuck();
            patovermelho.fly();

            Duck patoborracha = new RubberDuck();
            patoborracha.display();

            Duck patoMadeira = new DuckWood();
            patoMadeira.display();
            patoMadeira.quack();


            Duck patoMetal = new DuckMetal();
            patoMetal.display();
            patoMetal.quack();

        }
    }
}