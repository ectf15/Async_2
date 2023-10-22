using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Random random = new Random();

while (true)
{
    string nombre;
    Console.WriteLine("Ingrese un nombre: ");
    nombre = Console.ReadLine();
    DescargarInformacion(nombre);
}

async Task DescargarInformacion(string nombre){
    
    int tiempoAleatorio = random.Next(10000, 60000);
    await Task.Delay(tiempoAleatorio);

    Debug.WriteLine($"Información de {nombre} descargada con éxito");
}