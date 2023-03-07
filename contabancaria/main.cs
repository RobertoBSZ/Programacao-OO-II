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
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
     
    Boolean opcao_menu = true;
    Conta cliente1 = new Conta();
    int operacaouser;
    
    Console.WriteLine("Sistema Bancário\n");
    Console.WriteLine("Criação de Conta\n");
    Console.WriteLine("Cadastro de informações pessoais");
    Console.WriteLine("\nDigite o seu CPF:");
    cliente1.GetSetCpf = Console.ReadLine();
    Console.Clear();
    
    
    Console.WriteLine("Digite o seu nome:");
    cliente1.GetSetName = Console.ReadLine();
    Console.Clear();
    
    Console.WriteLine("\nConfirmação de suas informações\n");
    Console.WriteLine("CPF: " + cliente1.Cpf);
    Console.WriteLine("Nome: " + cliente1.Name);
    
    Console.WriteLine("\nOlá " + cliente1.Name + ", inscrito no CPF " + cliente1.Cpf + ", seu saldo inicial é de R" + cliente1.Saldo.ToString("C") + ".");
    
    
    while(opcao_menu == true){
        Console.WriteLine("\nEscolha sua operação bancária:\n1-Consultar\n2-Sacar\n3-Depositar\n4-Extrato\n5-Sair");
        Console.WriteLine("\nSua escolha:");
        operacaouser = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        if(operacaouser <=0 || operacaouser >5){
            Console.WriteLine("Escolha um número dentre as opções!");
        }
        else{
            switch(operacaouser){
            case 1:
                Console.WriteLine("\nSaldo atual: R" + cliente1.GetSaldo().ToString("C"));
                break;
            case 2:
                double x;
                Console.WriteLine("\nQuanto você quer sacar?");
                x = Convert.ToDouble(Console.ReadLine());
                cliente1.Sacar(x);
                
                Console.WriteLine("Saldo atual: R" + cliente1.GetSaldo().ToString("C"));
                break;
            case 3:
                double y;
                Console.WriteLine("\nQuanto você quer depositar?");
                y = Convert.ToDouble(Console.ReadLine());
                cliente1.Depositar(y);
                
                Console.WriteLine("Saldo atual: R" + cliente1.GetSaldo().ToString("C"));
                break;
            
            case 4:
                Console.WriteLine("Transações realizadas:\n");
                cliente1.Extrato_Bancario();
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