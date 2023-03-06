/******************************************************************************
-Aula dia 06/03-

Criação de conta e função:

Administrar uma conta bancária.
O que vai precisar de Atributos na classe cliente?

*CPF
*Nome
*Saldo Bancário

Ações (Métodos)?

*Sacar
*Depositar
*Extrato (Pode ser uma string)



*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Boolean opcao_menu = true;
    Cliente cliente1 = new Cliente();
    int operacaouser;
    
    while(opcao_menu == true){
        Console.WriteLine("Escolha sua operação bancária:\n1-Consultar\n2-Sacar\n3-Depositar\n4-Sair");
        operacaouser = Convert.ToInt32(Console.ReadLine());
        switch(operacaouser){
            case 1:
                Console.WriteLine("\nO seu saldo é:\n");
                Console.WriteLine(cliente1.GetSaldo());
                break;
            case 2:
                double x;
                Console.WriteLine("\nQuanto você quer sacar?\n");
                x = Convert.ToDouble(Console.ReadLine());
                cliente1.sacar(x);
                
                Console.WriteLine("Saldo atual: " + cliente1.GetSaldo());
                break;
            case 3:
                double y;
                Console.WriteLine("\nQuanto você quer depositar?\n");
                y = Convert.ToDouble(Console.ReadLine());
                cliente1.depositar(y);
                
                Console.WriteLine("Saldo atual: " + cliente1.GetSaldo());
                break;
                
            case 4:
                Console.WriteLine("\nVocê escolheu sair. Saindo...");
                opcao_menu = false;
                break;
        }       
    }
  }
}