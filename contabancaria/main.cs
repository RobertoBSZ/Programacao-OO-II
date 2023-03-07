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
    Boolean opcao_confirm = true;
    Boolean opcao_confirm2 = true;
    Conta cliente1 = new Conta();
    int operacaouser, user_confirm;
    
    Console.WriteLine("Sistema Bancário\n");
    Console.WriteLine("Criação de Conta\n");
    Console.WriteLine("Cadastro de informações pessoais\n");
    
    while(opcao_confirm == true){
        opcao_confirm2 = true;
        Console.WriteLine("Digite o seu CPF:");
        cliente1.GetSetCpf = Console.ReadLine();
        Console.Clear();
        
        
        Console.WriteLine("Digite o seu nome:");
        cliente1.GetSetName = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Confirmação de suas informações\n");
        Console.WriteLine("CPF: " + cliente1.Cpf);
        Console.WriteLine("Nome: " + cliente1.Name + "\n");
        
        while (opcao_confirm2 == true){
            Console.WriteLine("Você confirma essas informações?\n1- Sim\n2- Não");
            user_confirm = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            if(user_confirm == 2){
                Console.WriteLine("Repita o processo!");
                opcao_confirm2 = false;
            }else if(user_confirm == 1){
                opcao_confirm = false;
                opcao_confirm2 = false;
            }else{
                Console.WriteLine("Escolha uma opção válida.");
            }
        }
        
    }
    
    
    Console.WriteLine("Olá " + cliente1.Name + ", inscrito no CPF " + cliente1.Cpf + ", seu saldo inicial é de R" + cliente1.Saldo.ToString("C") + ".\n");
    
    
    while(opcao_menu == true){
        Console.WriteLine("Escolha sua operação bancária:\n1-Consultar\n2-Sacar\n3-Depositar\n4-Extrato\n5-Sair");
        Console.WriteLine("\nSua escolha:");
        operacaouser = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        if(operacaouser <=0 || operacaouser >5){
            Console.WriteLine("Escolha um número dentre as opções!");
        }
        else{
            switch(operacaouser){
            case 1:
                Console.WriteLine("Saldo atual: R" + cliente1.GetSaldo().ToString("C"));
                break;
            case 2:
                double x;
                Console.WriteLine("Quanto você quer sacar?");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                cliente1.Sacar(x);
                
                Console.WriteLine("Saldo atual: R" + cliente1.GetSaldo().ToString("C"));
                break;
            case 3:
                double y;
                Console.WriteLine("Quanto você quer depositar?");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                cliente1.Depositar(y);
                
                Console.WriteLine("Saldo atual: R" + cliente1.GetSaldo().ToString("C"));
                break;
            
            case 4:
                double z;
                Boolean w = true;
                Console.WriteLine("Transações realizadas:\n");
                cliente1.Extrato_Bancario();
                
                while(w == true){
                    Console.WriteLine("\nPressione 1 para continuar!");
                    z = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    if (z != 1){
                        Console.WriteLine("Erro!");
                    }else{
                        w = false;
                    }
                }
                break;
            case 5:
                Console.WriteLine("Você escolheu sair. Saindo...");
                opcao_menu = false;
                break;
            }       
        }
        
    }
  }
}