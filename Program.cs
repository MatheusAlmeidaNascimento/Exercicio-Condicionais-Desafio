using System;

namespace Exercicio_condicional_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            {
	
	
	 {
		int idadePessoa;
		Console.WriteLine("Qual é a sua idade?");
		idadePessoa = int.Parse(Console.ReadLine());
		
		if(idadePessoa < 5 ){
		    Console.WriteLine("você não é classificável");
		}
		
		else{
		    if(idadePessoa <= 7){
		        Console.WriteLine("Sua categoria é: Infantil A");
		    }
		    
		    else{
		        if(idadePessoa < 10 ){
		        Console.WriteLine("Sua categoria é: Infantil B");
		    }
		
		        else{
		            if(idadePessoa <= 13){
		            Console.WriteLine("Sua categoria é: Juvenil A");
		        }
		            else{
		                if(idadePessoa <= 17){
		                Console.WriteLine("Sua categoria é: Juvenil B");
		            
		        }
		        
		                else {
		                    Console.WriteLine("Sua categoria é: Sênior");
		            }
		        }
		    }
		    
		        
		    }
		}
	}
}

}
        }
    }

