using System;
class HelloWorld {
  static void Main() {
    Boolean opcao_menu = true;
    int operacaouser = 0;
    double x = 0;
    double y = 0;
    
    while(opcao_menu == true){
        Console.WriteLine("Escolha sua operação:\n1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Sair");
        operacaouser = Convert.ToInt32(Console.ReadLine());
        
        if(operacaouser <=0 || operacaouser >5){
            Console.WriteLine("Escolha um número entre 1 e 5!");
        }
        
        else{
            Console.WriteLine("Primeiro número:");
            x = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Primeiro número:");
            y = Convert.ToInt32(Console.ReadLine());
            
            Calculadora operacao = new Calculadora();
            
            switch(operacaouser){
                case 1:
                    Console.WriteLine("\nSomar!");
                    Console.WriteLine("\nO resultado é " + operacao.somar(x, y));
                    break;
                case 2:
                    Console.WriteLine("\nSubtrair!");
                    Console.WriteLine("\nO resultado é " + operacao.subtrair(x, y));
                    break;
                case 3:
                    Console.WriteLine("\nMultiplicar!");
                    Console.WriteLine("\nO resultado é " + operacao.multiplicar(x, y));
                    break;
                case 4:
                    Console.WriteLine("\nDividir!");
                    Console.WriteLine("\nO resultado é " + operacao.dividir(x, y));
                    break;
                case 5:
                    Console.WriteLine("\nVocê escolheu sair. Saindo...");
                    opcao_menu = false;
                    break;
            }
        }
    }
  }
}
using System;

class Calculadora
{

  public double somar (double a, double b)
  {
    return a + b;
  }
  public double subtrair (double a, double b)
  {
    return a - b;
  }
  public double multiplicar (double a, double b)
  {
    return a * b;
  }
  public double dividir (double a, double b)
  {
    return a / b;
  }
}

