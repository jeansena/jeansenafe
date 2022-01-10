using System;

namespace AreaRetangulo
{
    public class Retangulo
    {   
        //construtor atalho "ctor"
        public Retangulo()
        {
           this.Altura =0;
           this.Base = 0; 
        }

        //**Base do Retângulo ***
        //Probriedade atalho "profull"
        //atributo
        private int baseret;

        public int Base
        {
            get { return baseret; }

            set { 
                  if (value >= 0) baseret = value;
                  else
                  baseret =0;
                }
        }
        
        //**Altura do Retângulo**
        //probriedade
        //atributo variavel
        private int altret;

        public int Altura
        {
            get { return altret; }
            set {                 
                if(value >=0) altret = value;
                else altret = 0;
                }
        }
        
        //** Calcular Area **       
        public int Area
        {
            get { return altret*baseret; }
            
        }
        //Metodos Exibir
        public void ExibeDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }


    }   
}