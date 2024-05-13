using System;

class programaPaneles
{
    static int panelesMaximos(int a, int b, int x, int y) // se debe crear una clase estatica para poder obtener el resultado final.
    {
        // Se debe calcular una división entre el lado del techo X y dividirlo por el lado del panel a y lo mismo con el lado y (techo) con lado b(panel) 
        int techoX_panelA = x / a; // 3/2 
        int techoY_panelB = y / b; // 5/1

        // Para saber el número de paneles totales que caben dentro de un techo se deben multiplicar los resultados de las divisiones anteriores
        return techoX_panelA * techoY_panelB;
    }

    static void Main()
    {
        // Resultado
        Console.Write("Caben ");
        Console.WriteLine(panelesMaximos(2, 1, 3, 5)+" paneles solares en un techo"); // Salida: 5

    }
}