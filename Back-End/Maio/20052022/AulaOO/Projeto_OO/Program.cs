Lampada l = new Lampada();
l.potencia = 9;
l.ligar();
Console.WriteLine("Ligada? = " +l.ligado + " / Potencia = " + l.potencia);
l.desligar();
Console.WriteLine("Ligada? = " + l.ligado + " / Potencia = " + l.potencia);
double n;
n = l.retornaPotencia;
Console.WriteLine("A potência da lampada cadastrada = " + n);
Console.WriteLine("Retorno da função estaLigado = " + l.estaLigado());
l.ligar();
l.desligar();

if (l.estaLigada())
{
    Console.WriteLine("A lampada está ligada!");
}
else 
{
    Console.WriteLine("A lampada está desligada!");
}

public class Lampada
{
    public bool ligado; //aqui é true ou false! - Atributo
    public double potencia; // em OFF
    //métodos

    // visibilidade (public, private ou protected)
    // tipo de retorno -> void - não retorna nada
    // tipo de retorno -> int - retorna int

    public void ligar() 
    {
        Console.WriteLine("A lampada está sendo ligada!");
        ligado = true;
    }
    public void desligar () 
    {
        Console.WriteLine("A lâmpada está sendo desligada!");
        ligado = false;
    }

    public double retornaPotencia() 
    { 
        return potencia;
    }    
    public bool estaLigada()
    {
        return ligado; 
    }
}

