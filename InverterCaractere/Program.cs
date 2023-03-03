using System;

class Program
{
    static void Main(string[] args)
    {
        // Definindo a string a ser invertida
        string textoOriginal = "exemplo de texto para inverter";

        // Criando uma variável para armazenar o texto invertido
        string textoInvertido = "";

        // Percorrendo a string original de trás para frente e concatenando os caracteres na variável de texto invertido
        for (int i = textoOriginal.Length - 1; i >= 0; i--)
        {
            textoInvertido += textoOriginal[i];
        }

        // Exibindo o resultado na tela
        Console.WriteLine($"Texto original: {textoOriginal}");
        Console.WriteLine($"Texto invertido: {textoInvertido}");
    }
}
