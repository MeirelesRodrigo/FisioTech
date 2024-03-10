using Calculos;

namespace Fisiotech;

class Program{



    static CalculosParametros _calculos = new CalculosParametros();

    static void Main(string[] args){    
        Menu();
    }





    static void Menu(){
        Console.Clear();

        Console.WriteLine("|----------------------------|");
        Console.WriteLine("| 1 - PESO PREDITO E VOLUME  |");
        Console.WriteLine("| 2 -  GASOMETRIA ARTERIAL   |");
        Console.WriteLine("| 3 -     PI / PE MAX        |");
        Console.WriteLine("| 4 -   ESCALA DE GLASGOW    |");
        Console.WriteLine("| 5 -         SAIR           |");
        Console.WriteLine("|----------------------------|");

        OpcoesMenu();
    }


    static void OpcoesMenu(){
        Console.WriteLine("ESCOLHA UMA OPÇÃO");
        var opcao = Console.ReadLine();

        switch(int.Parse(opcao)){
            case 1: {
                _calculos.PesoPredito();
                Console.ReadKey();
                Menu();
                break;
            }
            case 2: {
                _calculos.GasometriaArterial();
                Console.ReadKey();
                Menu();
                break;
            }
            case 3: {
                _calculos.PiPeMax();
                Console.ReadKey();
                Menu();
                break;
            }
            case 4: {
                _calculos.EscalaGlasgow();
                Console.ReadKey();
                Menu();
                break;
            }
            case 5: {
                Environment.Exit(0);
                break;
            }
            default:{
                Console.Clear();
                Console.WriteLine("OPÇÃO INVÁLIDA");
                Console.ReadKey();
                Menu();
                break;
            }
        }

    }


}
