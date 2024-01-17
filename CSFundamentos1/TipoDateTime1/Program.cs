Console.WriteLine("## DateTime ## \n");

DateTime dataAtual = DateTime.Now;

//extrai informações

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

//adicionar valores
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));

//obter o dia da semana e do ano
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

//data no formato longo e curto
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());

Console.WriteLine(dataAtual.ToShortTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());