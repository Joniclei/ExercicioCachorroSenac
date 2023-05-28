//Crie a classe Cachorro com os atributos nome, dono,idade, qtdeBrinquedos e dormindo(boleano). Crie também2 métodos, um chamado Brincar e outro chamado Dormir

using System;

namespace Catioro
{
  public class Program
  {
    public static void Main(string[]args)
    {
      Cachorro ca1 = new Cachorro();
      Console.WriteLine("Qual nome do seu cachorro");
      ca1.Nome=Console.ReadLine();
      Console.WriteLine("Qual nome do dono");
      ca1.Dono=Console.ReadLine();
      Console.WriteLine("Qual nome a idade:");
      ca1.Idade=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Quantidade de brinquedos");
      ca1.QtdeBrinquedos=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ele esta dormindo");
      ca1.Dormindo = bool.Parse(Console.ReadLine());
      
      Console.WriteLine(ca1);
    }
  }
}

//Crie a classe Cachorro com os atributos nome, dono,idade, qtdeBrinquedos e dormindo(boleano). Crie também2 métodos, um chamado Brincar e outro chamado Dormir
