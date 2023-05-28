//Crie a classe Cachorro com os atributos nome, dono,idade, qtdeBrinquedos e dormindo(boleano). Crie também2 métodos, um chamado Brincar e outro chamado Dormir
namespace Catioro
{
  public class Cachorro
  {
    public string Nome {get;set;}
    public string Dono {get;set;}
    public int Idade {get;set;}
    public int QtdeBrinquedos{get;set;}
    public bool Dormindo {get;set;}

    public string Dormir()
    {
      string dorm = Dormindo ? "Esta dormindo" : "Nao esta dormindo";
      return dorm;
    }
    public static void Brincar()
    {
      Console.WriteLine("Brincando");
    }

    public override string ToString()
    {

      return $"{Nome} \n {Dono} \n {Idade} \n {QtdeBrinquedos} \n {Dormir()} ";
    }


  }
}
