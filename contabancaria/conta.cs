using System;
using System.Collections.Generic;

class Conta{
    public string Cpf;
    public string Name;
    public double Saldo;
    public List<string> extrato { get; private set; }
    
    public Conta(){
        this.Cpf = null;
        this.Name = null;
        this.Saldo = 1000;
        extrato = new List<string>();
    }
    
    public string GetSetCpf{
        get{
            return this.Cpf;
        }
        set{
            this.Cpf = value;
        }
    }
    
    public string GetSetName{
        get{
            return this.Name;
        }
        set{
            this.Name = value;
        }
    }
    
    public double GetSaldo(){
        return this.Saldo;
    }

    public void Extrato_Bancario(){
        foreach (string transacao in extrato){
            Console.WriteLine(transacao);
        }
    }
    
    public double Sacar (double a){
        if(Saldo < a){
            this.extrato.Add("Saque de R$ "+ a + " mal-sucedido");
            Console.WriteLine("Você possui saldo insuficiente. Saque mal-sucedido.\n");
            return this.Saldo;
        }
        else{
            this.extrato.Add("Saque de R$ "+ a + " realizado com sucesso!");
            return this.Saldo = Saldo - a;
        }
    }
    
    public double Depositar(double a){
        if(a <= 0){
            this.extrato.Add("Depósito de R$ "+ a +" mal-sucedido");
            Console.WriteLine("Este depósito é insuficiente. Deposito mal-sucedido.\n");
            return this.Saldo;
        }
        else{
            this.extrato.Add("Depósito de R$ "+ a +" realizado com sucesso!");
            return this.Saldo = this.Saldo + a;
        }
    }
}