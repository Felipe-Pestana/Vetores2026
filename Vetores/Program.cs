char[] numbers = new char [4];
int contador = 0;

void PopulaVetor(int contador)
{
    
    do
    {
        //Console.WriteLine("Informe o numero desejado na posição " + contador);
        Console.WriteLine($"Informe o numero desejada posição {contador}");
        numbers[contador] = char.Parse(Console.ReadLine());
        contador++;

    } while (contador < numbers.Length);
}

void MostraVetor()
{
    contador = 0;
    while (contador < numbers.Length)
    {
        Console.Write($"[{numbers[contador]}] ");
        contador++;
    }
}

PopulaVetor(contador);
MostraVetor();