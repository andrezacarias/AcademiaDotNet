 // Crie uma classe Carro com os atributos: modelo, marca, cor e placa. Crie um método para definir os
 // atributos, outro método para ligar o carro e outro método para desligar o carro.

Carro c = new Carro();

Console.WriteLine("Entre com a marca,modelo,cor e a placa do carro.");
c.marca = Console.ReadLine();
c.modelo = Console.ReadLine();
c.cor = Console.ReadLine();
c.placa = Console.ReadLine();

Console.WriteLine("Digite + para ligado ou - para desligado.");
c.onoff = Console.ReadLine();

if(c.onoff == "+")
{
    c.ligar();
}
else
{
    c.desligar();
}


Console.WriteLine($"O carro modelo {c.modelo} da marca {c.marca} cor {c.cor} e placa {c.placa} está {c.onoff} ");

public class Carro
{
    public string modelo;
    public string marca;
    public string cor;
    public string placa;
    public string onoff;

    public bool ligado;

    public void ligar()
    {
        
      onoff = "ligado";            
    
    }

    public void desligar()
    {

        onoff = "desligado";

    }

}
