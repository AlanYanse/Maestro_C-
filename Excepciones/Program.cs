using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 9;
            int num2 = 0;
            
            try{

                    
                int resultado = num1 / num2;
           
            }catch(Exception ex){
                
                Console.WriteLine(ex.Message);
            }

            

            Console.WriteLine("hello");
        }
    }
}
