// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una letra");
string LetraUno = Console.ReadLine();

Console.WriteLine(" La letra que ingresaste es:  " + LetraUno);

Console.WriteLine("Desea continuar? S/N");

string continuar = Console.ReadLine();

if( continuar.ToUpper() == "S")

{

    Console.WriteLine(" Usted decidio continuar");

}

else if ( continuar.ToUpper() == "N")
{

    Console.WriteLine(" Usted decidio no continuar");
}

else
{
    Console.WriteLine(" Debe ingresar un dato valido entre S para el SI o N para el NO");

}



