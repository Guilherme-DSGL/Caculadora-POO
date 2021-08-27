using System;
namespace hello_word {
    class Program {
        static void Main(string[] args) {
            
            var calcular = new Calculadora();
            var y = 0;
            var x = 0;
            while (y == 0) {
                Console.WriteLine("Digite um numero");
                calcular.n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("1- fatorial 2- selecionar outro numero");
                x = int.Parse(Console.ReadLine());
                switch (x) {
                    case 1:
                        calcular.Fatorial(calcular.n1);
                        Console.WriteLine(calcular.resultado);

                        break;
                    case 2:
                        Console.WriteLine("Digite um numero");
                        calcular.n2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Selecione 1- somar, 2-subtrair, 3- multiplicar, 4- dividir");
                        x = int.Parse(Console.ReadLine());
                        switch (x) {
                            case 1:
                                calcular.somar(calcular.n1, calcular.n2);
                                Console.WriteLine(calcular.resultado);
                                break;
                            case 2:
                                calcular.subtrair(calcular.n1, calcular.n2);
                                Console.WriteLine(calcular.resultado);
                                break;
                            case 3:
                                calcular.multiplicar(calcular.n1, calcular.n2);
                                Console.WriteLine(calcular.resultado);
                                break;
                            case 4:
                                calcular.dividir(calcular.n1, calcular.n2);
                                Console.WriteLine(calcular.resultado);
                                break;
                            default:
                                break;
                        }
                        break;
                        default:
                        break;
                }
            }
        }
    }
}
