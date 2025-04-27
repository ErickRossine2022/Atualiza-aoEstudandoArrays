using System.Xml.Linq;

class Program
{
    static void Main()
    {
        //arrays

        string[] names =
        {
            "Lucas",
            "Erick",
            "Gustavo",
            "Leticia",
            "Clara",
            "Larissa",
        }; //String

        int[] Idade = {
            20,
            19,
            35,
            18,
            18,
            32
        }; //Inteiro

        float[] Altura = {
            1.66f,
            1.80f,
            1.75f,
            1.72f,
            1.72f,
            1.55f
        }; //Flutuante


        int[] Tabuada = {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10
        };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Nome: {names[i]}\t Idade: {Idade[i]} anos\t Altura: {Altura[i]} de altura");
        }

        Console.WriteLine($"\n");
        foreach (string name in names)
        {
            Console.WriteLine($"Nome: {name}");
        }

        Console.WriteLine("\n");


        for (int Number = 1; Number <= 10; Number++)
        {
            Console.WriteLine("\n");
            for (int d = 0; d < Tabuada.Length; d++)
            {
                Console.WriteLine($"Operaçao do {Number} x {Tabuada[d]} = {Number * Tabuada[d]}");
            }

        }
    }
}

