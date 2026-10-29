using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("soy Fabian");
Console.Write("como tas?");
Console.WriteLine();
Console.WriteLine("--------------------------------");

int edad = 23;
float estatura = 1.6F;
double peso = 60.5;
bool esEstudiante = true;
string nombre = "LUIGI";
double pesoIdeal = 70;
int peso2 = (int)pesoIdeal;

Console.WriteLine("ingrese nombre del jugador: ");
string player = Console.ReadLine();
Console.WriteLine("el jugador es: " + player);

Console.WriteLine("ingrese nivel del jugador: ");
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("el nivel del jugador es {0} y su nombre {1}", nivel, player);

if (edad > 18)
{
    Console.Write("eres mayor de edad,");
    Console.WriteLine(" por lo tanto puedes entrar al juego");
}
else if (edad >= 15 && edad < 18)
{
    Console.WriteLine("puedes entrar pero con restricciones");
}
else
{
    Console.WriteLine("no puedes entrar al juego");
}

int tabla = 5;
for (int i = 0; i < 5; i = i + 2)
{
    Console.WriteLine("el valor de i es " + i);
}
