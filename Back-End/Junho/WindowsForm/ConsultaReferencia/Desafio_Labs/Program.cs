int valorCobrado;
DateTime tempoAgora = DateTime.Now;
DateTime tempoSaida = Convert.ToDateTime("20:23:00");

TimeSpan Tempo = tempoSaida.Subtract(tempoAgora);

string[] contaTempo = Tempo.ToString().Split(':');

int tempoHora = Convert.ToInt16(contaTempo[0]);
int tempoMinuto = Convert.ToInt16(contaTempo[1]);

if (tempoMinuto > 0)
{
    tempoHora++;
}

valorCobrado = tempoHora * 5;


if (tempoMinuto > 0)
{
    tempoHora--;
}


Console.WriteLine("Você ficou estacionado " + tempoHora  + " horas e " + tempoMinuto + " minutos você deve R$" + valorCobrado + ",00.");

//contaTempo = Convert.(contaTempo);


//DateTime dt1 = DateTime.Now;
//DateTime dt2 = new DateTime(2022, 06, 12);
//TimeSpan ts1 = dt1.Subtract(dt2);
//string total = string.Format("{0}:{1}:{2}", Convert.ToInt64(ts1.TotalHours), ts1.Minutes, ts1.Seconds);
//Console.WriteLine(total);