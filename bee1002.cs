using System; 

class URI {

    static void Main(string[] args) { 

        double pi = 3.14159d; 
        double raio = double.Parse(Console.ReadLine());
        double area = Math.Round(pi * Math.Pow(raio, 2), 4);

            Console.WriteLine("A={0:0.0000}",area);

    }

}
