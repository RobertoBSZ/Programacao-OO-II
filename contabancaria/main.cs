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
    Conta cliente1 = new Conta();
    int operacaouser;
    
    Console.WriteLine("Sistema Bancário\n");
    Console.WriteLine("Criação de Conta\n");
    Console.WriteLine("Cadastro de informações pessoais");
    Console.WriteLine("\nDigite o seu CPF:");
    cliente1.setCpf = Console.ReadLine();
    
    Console.WriteLine("\nDigite o seu nome:");
    cliente1.setName = Console.ReadLine();
    
    Console.WriteLine("\nConfirmação de suas informações\n");
    Console.WriteLine("CPF: " + cliente1.GetCpf());
    Console.WriteLine("Nome: " + cliente1.GetName());
    
    Console.WriteLine("\nSeu saldo inicial é de R$1000,00\n");
    
    
    while(opcao_menu == true){
        Console.WriteLine("\nEscolha sua operação bancária:\n1-Consultar\n2-Sacar\n3-Depositar\n4-Sair");
        Console.WriteLine("\nSua escolha:");
        operacaouser = Convert.ToInt32(Console.ReadLine());
        switch(operacaouser){
            case 1:
                Console.WriteLine("\nSaldo atual: R$" + cliente1.GetSaldo());
                break;
            case 2:
                double x;
                Console.WriteLine("\nQuanto você quer sacar?");
                x = Convert.ToDouble(Console.ReadLine());
                cliente1.Sacar(x);
                
                Console.WriteLine("Saldo atual: R$" + cliente1.GetSaldo());
                break;
            case 3:
                double y;
                Console.WriteLine("\nQuanto você quer depositar?\n");
                y = Convert.ToDouble(Console.ReadLine());
                cliente1.Depositar(y);
                
                Console.WriteLine("Saldo atual: R$" + cliente1.GetSaldo());
                break;
                
            case 4:
                Console.WriteLine("\nVocê escolheu sair. Saindo...");
                opcao_menu = false;
                break;
        }       
    }
  }
}
