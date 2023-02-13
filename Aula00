using System;
class HelloWorld {
  static void Main() {
    
    
    
    PopulacaoBarata baratas = new PopulacaoBarata();
    
    Console.WriteLine("\nA populção de barata é:\n");
    Console.WriteLine(baratas.GetQtdeBaratas());
    
    baratas.Spray();
    baratas.Spray();
    
    Console.WriteLine("\nA populção de barata é:\n");
    Console.WriteLine(baratas.GetQtdeBaratas());
    
    baratas.AumentaBaratas();
    
    Console.WriteLine("\nA populção de barata é:\n");
    Console.WriteLine(baratas.GetQtdeBaratas());
  }
}

using System;

class PopulacaoBarata{
    public int QtdeBaratas = 0;
    
    public PopulacaoBarata(){
        this.QtdeBaratas = 100;
    }
    
    public int GetQtdeBaratas(){
        return this.QtdeBaratas;
    }
    
    public void Spray(){
        this.QtdeBaratas = (int)(this.QtdeBaratas*0.9);
    }
    
    public void AumentaBaratas(){
        this.QtdeBaratas = (int)(this.QtdeBaratas*1.5);
    }
    
}
