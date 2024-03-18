// See https://aka.ms/new-console-template for more information
Console.WriteLine("SWITCH CASE NO C#");


int valor = 300;



Console.WriteLine("Deseja parcelar em quantas prestações (Max em 3x)");
int prestacao = Convert.ToInt32(Console.ReadLine());


switch(prestacao)
{
    case 1: // se for 1
        Console.WriteLine("Prestação no valor de 300");
       break;

    case 2: // se for 2
        Console.WriteLine("Prestação no valor de 150");
        break;
    case 3: // se for 3
        Console.WriteLine("Prestação no valor de 100");
        break;

    default: // caso o valor seja diferentes dos 1 , 2 e 3
        Console.WriteLine("Valor digitado inválido");
        break;
    

}
    
