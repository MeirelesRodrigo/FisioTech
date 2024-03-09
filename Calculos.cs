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

        Console.WriteLine("DADOS CADASTRADOS, PRESSIONE [ENTER] PARA PROSEGUIR");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("*************************");
        Console.WriteLine("         GASOMETRIA      ");
        Console.WriteLine("PH....:  "+ph);
        Console.WriteLine("PACO2.: "+paco2);
        Console.WriteLine("HCO3..: "+hco3);
        Console.WriteLine("*************************");
       
        if(ph <7.35 && hco3 <22){
            Console.WriteLine("RESULTADO: ACIDOSE METABÓLICA ");
        }
        else if(ph <7.45 && paco2 >45){
            Console.WriteLine("RESULTADO: ACIDOSE RESPIRATÓRIA");
        }
        else if(ph > 7.45 && hco3 >26){
            Console.WriteLine("RESULTADO: ALCALOSE METABÓLICA");
        }
        else if(ph > 7.45 && paco2 <35){
            Console.WriteLine("RESULTADO: ALCALOSE RESPIRATÓRIA");
        }
        else{
            Console.WriteLine("GASOMETRIA DENTRO DO NORMAL");
        }
        Console.WriteLine("PRESSIONE [ENTER] PARA PROSEGUIR");
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
                Console.WriteLine("PESO IDEAL...: "+pesopredito+" KG");
                Console.WriteLine("VENTILANDO COM 4ML/KG...:"+pesopredito*4+" ML");
                Console.WriteLine("VENTILANDO COM 6ML/KG...:"+pesopredito*6+" ML");
                Console.WriteLine("VENTILANDO COM 8ML/KG...:"+pesopredito*8+" ML");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("PRESSIONE [ENTER] PARA PROSEGUIR");
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
                Console.WriteLine("PESO IDEAL...: "+pesopredito+" KG");
                Console.WriteLine("VENTILANDO COM 4ML/KG...:"+pesopredito*4+" ML");
                Console.WriteLine("VENTILANDO COM 6ML/KG...:"+pesopredito*6+" ML");
                Console.WriteLine("VENTILANDO COM 8ML/KG...:"+pesopredito*8+" ML");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("PRESSIONE [ENTER] PARA PROSEGUIR");
                break;
            }
            default:{
                Console.Clear();
                Console.WriteLine("OPÇÃO INVÁLIDA");
                break;
            }

        }
    }

}