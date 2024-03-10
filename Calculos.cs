using System.Runtime.Remoting;

namespace Calculos;


public class CalculosParametros(){

    
    
    
    
    public void EscalaGlasgow()
    {
        Console.Clear();
        Console.WriteLine("                     ABERTURA OCULAR                      ");
        Console.WriteLine("1 - OLHOS ABERTOS PREVIAMENTE À ESTIMULAÇÃO.......: 04 PTS");
        Console.WriteLine("2 - ABERTURA OCULAR APÓS ORDEM VERBAL.............: 03 PTS");
        Console.WriteLine("3 - À RESPOSTA DOLOROSA...........................: 02 PTS");
        Console.WriteLine("4 - NENHUMA RESPOSTA..............................: 01 PTS");
        
        Console.WriteLine("INFORME A PONTUAÇÃO");
        var ocular = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("                    RESPOSTA VERBAL                       ");
        Console.WriteLine("1 - RESPOSTA VERBAL ADEQUADA, ORIENTADA...........: 05 PTS");
        Console.WriteLine("2 - RESPOSTA VERBAL NÃO ORIENTADA, + COERENTE.....: 04 PTS");
        Console.WriteLine("3 - PALAVRAS INAPROPRIADAS........................: 03 PTS");
        Console.WriteLine("4 - SONS INTELEGÍVEIS ............................: 02 PTS");
        Console.WriteLine("5 - NENHUMA RESPOSTA..............................: 01 PTS");
        var verbal = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("                    RESPOSTA MOTORA                       ");
        Console.WriteLine("1 - OBEDECE A COMANDOS............................: 06 PTS");
        Console.WriteLine("2 - RESPONDE AO LOCAL DA DOR......................: 05 PTS");
        Console.WriteLine("3 - RETIRADA À DOR................................: 04 PTS");
        Console.WriteLine("3 - FLEXÃO ANORMAL AOS ESTÍMULOS DOLOROSOS........: 03 PTS");
        Console.WriteLine("4 - EXTENSÃO ANORMAL A ESTÍMULOS DOLOROSOS........: 02 PTS");
        Console.WriteLine("5 - NENHUMA RESPOSTA..............................: 01 PTS");
        var motora = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("       RESULTADO                       ");



        int pontuacao = (ocular + verbal + motora);

        if (pontuacao >= 13 && pontuacao <= 15)
        {
            Console.WriteLine("A PONTUAÇÃO DE FOI : " + pontuacao + " PTS");
            Console.WriteLine("CLASSIFICAÇÃO > LEVE");
        }
        else if(pontuacao >= 9 && pontuacao <= 12)
        {
            Console.WriteLine("A PONTUAÇÃO DE FOI : " + pontuacao + " PTS");
            Console.WriteLine("CLASSIFICAÇÃO > MODERADA");
        }
        else if (pontuacao >= 3 && pontuacao <= 8)
        {
            Console.WriteLine("A PONTUAÇÃO DE FOI : " + pontuacao + " PTS");
            Console.WriteLine("CLASSIFICAÇÃO > GRAVE");
        }
        else if(pontuacao < 3)
        {
            Console.WriteLine("A PONTUAÇÃO DE FOI : " + pontuacao+" PTS");
            Console.WriteLine("CLASSIFICAÇÃO > COMA");
        }
    }

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