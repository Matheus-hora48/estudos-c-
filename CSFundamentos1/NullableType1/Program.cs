// See https://aka.ms/new-console-template for more information

Console.WriteLine("Nullable Type");


//para receber valor null so colocar o ?
int? i = null;

int? a = null;
int b = a ?? 0;

Console.WriteLine(i);

//HasValue usado para verificar se um variavel tem um valor null, Value exibe o valor atribuido