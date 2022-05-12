// Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
// link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
// do arquivo usando este link (em minutos).

double tamanhoArquivo, velocidade, tempo;

Console.WriteLine("Entre com o tamanho do arquivo em MB e a velocidade de download em Mbps:");
tamanhoArquivo = double.Parse(Console.ReadLine());
velocidade = double.Parse(Console.ReadLine());

velocidade = (velocidade / 8);

tempo = Math.Round(((tamanhoArquivo / velocidade) / 60),2);

Console.WriteLine("O arquivo de " + tamanhoArquivo + "MB será baixado em " + tempo + " minutos.");
