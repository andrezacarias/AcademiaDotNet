// Fazer um laço (repetição) que fique solicitando números ao usuário. 
// Se o usuário digitar 0 o programa em VS deve parar. 
// Caso contrário, o programa em VS deve informar se o número é par ou ímpar
// e se ele é um número primo.   

int numero, divisores=1;

do
{
    Console.WriteLine("Digite um número inteiro.");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero != 0)
    {

        if (numero % 2 == 0)
        {
            Console.Clear();
            Console.WriteLine($"O { numero} é um número par!");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"O { numero} é um número ímpar!");
            
            for(int i = numero; i > 0; i--)
            {
                if(numero % i == 0)
                {
                    divisores++;
                }
                if(divisores == 2)
                {
                    //Console.Clear();
                    Console.WriteLine($"O {numero} é um numero primo!");
                    divisores = 0;
                }
            }
        }
    }

}while(numero != 0);