// See Sentencia de salto
for(int i = 1; i <= 10; i++)
{
    //detener el bucle para pasar a otra seccion
    if (i == 5)
    {
        //break;     se termina el bucle hasta el valor evaluado en el if
        continue;   //continua a pesar del valor a evaluar incluso omitiendo dicho valor mencionado
    }
    Console.WriteLine(i);
}
Console.WriteLine("fin");
