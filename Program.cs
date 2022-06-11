using System;
using System.Globalization;

Console.Clear();

// var data = new DateTime(2022, 06, 11, 11, 14, 10);// struct, estrutura ja montada zerada com, hora, min, segundos, ano, mes e dia.
// var data = DateTime.Now;// data atual.

// Console.WriteLine(data);
// Console.WriteLine(data.Year);
// Console.WriteLine(data.Month);
// Console.WriteLine(data.Day);
// Console.WriteLine(data.Hour);
// Console.WriteLine(data.Minute);
// Console.WriteLine(data.Second);
// Console.WriteLine(data.DayOfWeek); // Dia da semana.
// Console.WriteLine(data.DayOfYear); // Dia do Ano.

// var data = DateTime.Now;

// Y para ano, M mes, d para dia, m minuto, h para hora, 
// var formatada = String.Format("{0:yyyy-MM-dd}", data); // Linha formatada da data.
// F mostra a data toda {0:F}, R mostra toda da e hora padrão.
// Console.WriteLine(formatada);   


// Console.WriteLine(data);
// Console.WriteLine(data.AddDays(12));
// Console.WriteLine(data.AddMonths(1));
// Console.WriteLine(data.AddYears(1)); // Todos metodos corretos para add dias, meses e anos em uma data.


// if(data.Date <= DateTime.Now.Date) // Camparando as datas em dias.
// {
  //   Console.WriteLine("É igual");
// }


// var pt = new CultureInfo("pt-PT");
// var br = new CultureInfo("pt-BR");
// var en = new CultureInfo("en-US");
// var de = new CultureInfo("de-DE");
// var atual = CultureInfo.CurrentCulture; // Pega cultura da maquina atual.

// Console.WriteLine(DateTime.Now.ToString("D", pt));
// Console.WriteLine(string.Format("{0:D}", DateTime.Now));
// Console.WriteLine(DateTime.Now.ToString("D", atual));

// var utcDate = DateTime.UtcNow;

// Console.WriteLine(DateTime.Now); // Hora local da maquina (linguagem da maquina). 
// Console.WriteLine(utcDate); // Hora mundial.

// Console.WriteLine(utcDate.ToLocalTime()); // Convertendo a hora mundial para hora local.

// var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

// Console.WriteLine(timezoneAustralia);


// var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

// Console.WriteLine(horaAustralia);


// var timezones = TimeZoneInfo.GetSystemTimeZones(); // Hora mundial de todas

// foreach (var timezone in timezones)
// {
//     Console.WriteLine(timezone.Id);
//     Console.WriteLine(timezone);
//     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
//     Console.WriteLine("-----------------------------------------");
// }


// var timeSpan = new TimeSpan(); // Formatando o tempo bem preciso, usa-se para calculo de horas.
// Console.WriteLine(timeSpan);

// var timeSpanNanosegundos = new TimeSpan(1);
// Console.WriteLine(timeSpanNanosegundos);

// var timeSpanHoraMinutosSegundos = new TimeSpan(5, 12, 8);
// Console.WriteLine(timeSpanHoraMinutosSegundos);

// var timeSpanDiaHoraMinutosSegundos = new TimeSpan(3, 5, 50, 10);
// Console.WriteLine(timeSpanDiaHoraMinutosSegundos);

// var timeSpanDiaHoraMinutosSegundosMilissegundos = new TimeSpan(15, 12, 5, 50, 1000);
// Console.WriteLine(timeSpanDiaHoraMinutosSegundosMilissegundos);


// Console.WriteLine(DateTime.DaysInMonth(2022, 2)); // comoando para mostrar quantos dias tem no ano 2022 mes 2.
// Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek)); // Função para saber se o dia cai em fim de semana.
// Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // Função para saber se estamnos em horario de verão.

// static bool IsWeekend(DayOfWeek today) // Metodo não pronto para saber se e fim de semana.
// {
//     return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
// }



