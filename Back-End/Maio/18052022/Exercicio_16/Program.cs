// 16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
// multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
// (N*3; N * 3 * 3; N * 3 * 3 * 3; etc).

double numero = 5, transporte=0;


while(numero <= 250000000000)
    {
            numero = numero * 3;
        //Console.WriteLine(numero);

        if(numero <= 250000000000)
        {
            transporte = numero;
        }

    }

Console.WriteLine(transporte);