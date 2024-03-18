// See https://aka.ms/new-console-template for more information
Console.WriteLine("## uso de While e For");


Console.WriteLine("Escolha um numero de para fazer a tabuada entre 1 a 9");
int numeroTabuada = Convert.ToInt32(Console.ReadLine());

if(numeroTabuada >= 10 || numeroTabuada <= 0 )
{
    Console.WriteLine("Numero inválido, somente entre 1 a 9");
}

int multiplicador = 1;

while(multiplicador < 11)
{
    Console.WriteLine($"{numeroTabuada} * {multiplicador} = {numeroTabuada * multiplicador} \n");
    multiplicador++;
}

Console.WriteLine("=============================\n");
Console.WriteLine("Uso do for");

Console.WriteLine("Escolha um numero de para fazer a tabuada entre 1 a 9");
int numeroTabuadaFor = Convert.ToInt32(Console.ReadLine());

if (numeroTabuadaFor >= 10 || numeroTabuadaFor <= 0)
{
    Console.WriteLine("Numero inválido, somente entre 1 a 9");
}

int multiplicadorFor = 1;

for(int i = 0; multiplicadorFor < 11; multiplicadorFor++) // enquanto o multiplicadorFor for menor que 11
{
    Console.WriteLine($"{numeroTabuadaFor} * {multiplicadorFor} = {numeroTabuadaFor * multiplicadorFor} \n");
}