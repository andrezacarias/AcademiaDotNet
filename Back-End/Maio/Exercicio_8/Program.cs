// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.\n" + 
"A fórmula da conversão é F = (9 * C + 160) / 5.");

int graucelsius;
int graufahrenheit;


Console.WriteLine("Digite a temperatura em graus Celsius");
graucelsius = int.Parse(Console.ReadLine());

graufahrenheit = (9 * graucelsius + 160) / 5;

Console.WriteLine("O valor da temperatura em graus Celsius é " + graucelsius + "°C e convertido em Fahrenheit é\n" +
    " de " + graufahrenheit + "°C.");