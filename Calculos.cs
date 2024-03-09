using System.Runtime.Remoting;

namespace Calculos;


public class CalculosParametros(){

    public void GasometriaArterial(){
        Console.Clear();
        Console.WriteLine("| GASOMETRIA ARTERIAL |");
        
        Console.WriteLine("INFORME O PH:");
        var ph = double.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("INFORME A PACO2:");
        var paco2 = double.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("INFORME O HCO3:");
        var hco3 = double.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("DADOS CADASTRADOS, PRESSIONE [ENTER] PARA PROSSEGUIR");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("*************************");
        Console.WriteLine("         GASOMETRIA      ");
        Console.WriteLine("PH....:  "+ph);
        Console.WriteLine("PACO2.: "+paco2);
        Console.WriteLine("HCO3..: "+hco3);
        Console.WriteLine("*************************");

        if (ph < 7.35 && paco2 > 45 && hco3 > 26) 
        {
            Console.WriteLine("RESULTADO: DISTÚRBIO RESPIRATÓRIO ACIDÓTICO COM COMPENSAÇÃO METABÓLICA");
        }
        else if (ph < 7.35 && paco2 > 45 && hco3 < 22) 
        {
            Console.WriteLine("RESULTADO: DISTÚRBIO RESPIRATÓRIO ACIDÓTICO COM ACIDOSE METABÓLICA CONCOMITANTE");
        }
        else if (ph < 7.35 && paco2 < 35 && hco3 < 22)
        {
            Console.WriteLine("RESULTADO: DISTÚBIO MISTO ACIDÓTICO");
        }
        else if (ph > 7.45 && paco2 < 35 && hco3 < 22)
        {
            Console.WriteLine("RESULTADO: DISTÚBIO RESPIRATÓRIO ALCALÓTICO COM ACIDOSE METABÓLICA CONCOMITANTE");
        }
        else if (ph > 7.45 && paco2 < 35 && hco3 > 26)
        {
            Console.WriteLine("RESULTADO: DISTÚRBIO RESPIRATÓRIO COM COMPENSAÇÃO METABÓLICA");
        }
        else if (ph > 7.45 && paco2 > 45 && hco3 > 26)
        {
            Console.WriteLine("RESULTADO: DISTÚRBIO MISTO ALCALÓTICO");
        }
        else
        {
            Console.WriteLine("GASOMETRIA DENTRO DA NORMALIDADE");
        }

        Console.WriteLine("PRESSIONE [ENTER] PARA PROSSEGUIR");
        Console.ReadKey();
    }

    public void PesoPredito(){
        Console.Clear();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("| SELECIONE O SEXO DO PACIENTE | ");
        Console.WriteLine("| 1 -         MASCULINO        |");
        Console.WriteLine("| 2 -         FEMININO         |");
        Console.WriteLine("---------------------------------");
        MenuPesoPredito();
    }

    public void MenuPesoPredito(){
        Console.WriteLine("ESCOLHA UMA OPÇÃO");
        var opcaoPeso = Console.ReadLine();

        switch(int.Parse(opcaoPeso)){
            case 1:{
                Console.Clear();
                Console.WriteLine("SEXO MASCULINO");
                Console.WriteLine("INFORME A ALTURA EM CM - EX 1,83 = 183CM");
                var altura = double.Parse(Console.ReadLine());
                var pesopredito = 50 + 0.91 * (altura - 152.4);
                
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("PESO IDEAL...: "+pesopredito.ToString("00.00")+" KG");
                Console.WriteLine("VENTILANDO COM 4ML/KG...:"+(pesopredito*4).ToString("000.00")+" ML");
                Console.WriteLine("VENTILANDO COM 6ML/KG...:"+(pesopredito*6).ToString("000.00")+" ML");
                Console.WriteLine("VENTILANDO COM 8ML/KG...:"+(pesopredito*8).ToString("000.00")+" ML");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("PRESSIONE [ENTER] PARA PROSSEGUIR");
                break;
            }
            case 2:{
                Console.Clear();
                Console.Clear();
                Console.WriteLine("SEXO FEMININO");
                Console.WriteLine("INFORME A ALTURA EM CM - EX 1,60 = 160CM");
                var altura = double.Parse(Console.ReadLine());
                var pesopredito = 45.5 + 0.91 * (altura - 152.4);
                
                
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("PESO IDEAL...: "+pesopredito.ToString("000.00")+" KG");
                Console.WriteLine("VENTILANDO COM 4ML/KG...:"+(pesopredito*4).ToString("000.00") + " ML");
                Console.WriteLine("VENTILANDO COM 6ML/KG...:"+(pesopredito*6).ToString("000.00") + " ML");
                Console.WriteLine("VENTILANDO COM 8ML/KG...:"+(pesopredito*8).ToString("000.00") + " ML");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("PRESSIONE [ENTER] PARA PROSSEGUIR");
                break;
            }
            default:{
                Console.Clear();
                Console.WriteLine("OPÇÃO INVÁLIDA");
                break;
            }

        }
    }

    public void PiPeMax()
    {
        Console.Clear();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("| SELECIONE O SEXO DO PACIENTE | ");
        Console.WriteLine("| 1 -         MASCULINO        |");
        Console.WriteLine("| 2 -         FEMININO         |");
        Console.WriteLine("---------------------------------");
        MenuPiPexMax();
    }

    public void MenuPiPexMax()
    {
        Console.WriteLine("ESCOLHA UMA OPÇÃO");
        var opcao = int.Parse(Console.ReadLine());

        switch (opcao){
            case 1:
                {
                    Console.Clear();
                    Console.WriteLine("INFORME A IDADE DO PACIENTE");
                    
                    var idade = int.Parse(Console.ReadLine());
                    var pimax = -1.14 * (idade) + 149.33;
                    var pemax = -1.26 * (idade) + 183.31;

                    Console.WriteLine("|-----------------------------");
                    Console.WriteLine("|            RESULTADO        ");
                    Console.WriteLine("  PI-MAX......:" + pimax.ToString("000.00") + " mmH2O ");
                    Console.WriteLine("  PE-MAX......:" + pemax.ToString("000.00") + " mmH2O ");
                    Console.WriteLine("-----------------------------");

                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("INFORME A IDADE DO PACIENTE");

                    var idade = int.Parse(Console.ReadLine());
                    var pimax = -0.46 * (idade) + 74.25;
                    var pemax = -0.68 * (idade) + 119.35;

                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("           RESULTADO         ");
                    Console.WriteLine("  PI-MAX......:" + pimax.ToString("000.00") + " mmH2O ");
                    Console.WriteLine("  PE-MAX......:" + pemax.ToString("000.00") + " mmH2O ");
                    Console.WriteLine("-----------------------------");
                    break;
                }
            default:
                {
                    Console.Clear();    
                    Console.WriteLine("OPÇÃO INCORRETA");
                    Console.ReadKey();
                    PiPeMax();
                    break;
                }

        }
    }
}