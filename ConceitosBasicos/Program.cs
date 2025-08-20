/*
Byte idade = 20;
string nome;
Console.Write("Digite seu nome:");
nome = Console.ReadLine();
Console.Write("Digite seu nome:");
idade = Convert.ToByte(Console.ReadLine()); 
Console.WriteLine("Ola " + nome + ". A idade informada foi {0}", idade);
*/


try
{
    decimal salario, irpfDevido;
    Console.Write("Informe seu salario:");
    salario = decimal.Parse(Console.ReadLine());

    if (salario <= 2428.8m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 182.16m;

    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 394.16m;

    else if (salario <= 4664.78m)
        irpfDevido = salario + 0.225m - 675.49m;

    else irpfDevido = salario + 0.275m - 908.73m;

    Console.WriteLine($"Para o salario {salario} a ser pago é {irpfDevido}");

}
catch(FormatException)
{
    Console.WriteLine("Digite apenas valores numéricos");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Entre em contato com o suporte técnico");
    Console.WriteLine(e.ToString());
}


