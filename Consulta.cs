using System;

class Consulta {
    
    static void Main(){

        int tempo=0;
        char escolha='';

        inicio;

        Console.Clear()

        Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
        Console.WriteLine("Escolha o Transporte:[a]Avião |  [c]Carro | [o]Ônibus :  ");

        escolha=char.Parse(Console.ReadLine().ToLower());

        switch(escolha){
            case 'a':
                tempo=50;
                break;
            case 'c';
                tempo=480;
                break;
            case 'o':
                tempo=660;
                break;
            default:
                tempo=-1;
                break
        }

        if(tempo<0){
            Console.WriteLine("Erro ao caucular o tempo de viagem");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo de duração de viagem será de: {0}minutos", tempo );
        }

        Console.WriteLine("Caucular outro transporte?[s/n]");
        escolha=char.Parse(Console.ReadLine());
        if(escolha=='s'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim daaplicação.")
        }
    }
}
