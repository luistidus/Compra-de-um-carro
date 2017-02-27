using System;
class MainClass {
  public static void Main (string[] args)
  {
     int pont, model, adc, color, motor, pne;
     double soma;
     soma = 0;

        Console.WriteLine("Vamor calcular o valor total da compra do seu carro");
        
        Console.WriteLine ("Iforme quantos pontos possui na carteira");
          pont = int.Parse(Console.ReadLine());
          
          if ( pont <7 )
          {
           //escolha do carro
            Console.WriteLine("Escolha abaixo os tipos de carro");
            Console.WriteLine(" 1) Uno -R$ 30.000,00");
            Console.WriteLine(" 2) Hb 20 -R$ 40.000,00");
            Console.WriteLine(" 3) New Fiesta -R$ 50.000,00");
            Console.WriteLine(" 4) Honda Fit -R$ 60.000,00");
            model = int.Parse(Console.ReadLine());
            
         switch(model)
            {
            case 1:
            {
              model = 30000;
              break;
            }    
            case 2:
            {
              model = 40000;
              break;
              
            } case 3:
            {
              model = 50000;
              break;
            } case 4:
            {
              model = 60000;
              break;
            } 
            
            }
            //fim escolha carro
            
            //Inicio escolha adicionais
            Console.WriteLine("Escolha abaixo os adicionais");
              Console.WriteLine(" 1) Ar condicionado -R$ 3.000,00");
            Console.WriteLine(" 2) Air Bag R$ 2.000,00");
            Console.WriteLine(" 3) Direcao eletronica R$ 1.000,00");
            Console.WriteLine(" 4) Cambio Automatico R$ 4.000,00");
            Console.WriteLine(" 5) Nenhum");
            adc = int.Parse(Console.ReadLine());
            
            switch(adc)
            {
            case 1:
            {
              adc = 3000;
              break;
            }    
            case 2:
            {
              adc = 2000;
              break;
              
            } case 3:
            {
              adc = 1000;
              break;
            } case 4:
            {
              adc = 4000;
              break;
            } 
            case 5:
            {
              adc = 0;
              break;
            } 
            }
            
            //Fim escolha adicionais
            
            //Inicio cores
             Console.WriteLine("Escolha o tipo de cor");
            Console.WriteLine(" 1) Solida");
            Console.WriteLine(" 2) Metalica");
            Console.WriteLine(" 3) Personalizada");
            color = int.Parse(Console.ReadLine());
            
            switch(color)
            {
            case 1:
            {
              color = 0;
              break;
            }    
            case 2:
            {
              color = 1000;
              break;
              
            } case 3:
            {
              color = 2000;
              break;
            } 
            
            }
            //Fim Cores
            
            //Inicio motor
               Console.WriteLine("Escolha o tipo de cor");
            Console.WriteLine(" 1) Motor 1.0");
            Console.WriteLine(" 2) Motor 2.0");
            motor = int.Parse(Console.ReadLine());
            
            switch(motor)
            {
            case 1:
            {
              motor = 0;
              break;
            }    
            case 2:
            {
              motor = 5000;
              break;
            }
            }
            //Fim do motor
            
            //Decisão portador
            
            Console.WriteLine("Voce e portador de necessidades especiais");
            Console.WriteLine(" 1) Sim");
            Console.WriteLine(" 2) Nao");
            
            pne = int.Parse(Console.ReadLine());
            
          switch(pne)
            {
            case 1:
            {
              soma = (motor+color+adc+model)-(motor+color+adc+model)*0.3;
              break;
            }    
            case 2:
            {
              soma = (motor+color+adc+model);
              break;
            }
            }
            
            Console.WriteLine("O valor total do carro é"+soma);                       
          }
    
          else
            {
             Console.WriteLine("Infelizmete nao esta habilitado a compra de um carro"); 
            }
             
    
  
  }
}
