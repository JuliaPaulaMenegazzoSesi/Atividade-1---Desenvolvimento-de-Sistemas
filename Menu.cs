using System;

int x;
Console.WriteLine("Selecione o tubérculo que você deseja obter mais informações: \n" +
    "1 - Batata\n" +
    "2 - Begônia\n" +
    "3 - Inhame");
x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("A Solanum tuberosum, comumente conhecida como batata[1], é uma planta perene da família das solanáceas e pertencente ao tipo fisionómico dos terófitos.[2] A planta adulta, conhecida como batateira, tem geralmente entre sessenta a cem centímetros de altura, possui flores e frutos e produz um tubérculo comestível rico em amido.[2]");
        break;
    case 2:
        Console.WriteLine("Begónias (ou begônias) são plantas essencialmente do género Begonia, família Begoniaceae, existindo apenas uma outra espécie de origem havaiana, única representante do género Hillebrandia, que não pertence a este género. São, de maneira geral, plantas ornamentais de folhagem característica, e ocasionalmente flores atraentes. Estimativas apontam para cerca de 1000 espécies de begónias. O Angiosperm Phylogeny Group aponta para a cifra de 1400 espécies, o que faz do género Begonia um dos 10 maiores do grupo das angiospermas.");
        break;
    case 3:
        Console.WriteLine("Inhame[1] é o nome comum um tubérculo cultivável pertencente a várias espécies da família das dioscoreáceas e das aráceas. Aos seus tubérculos também se chama inhame.[1]\r\n\r\nDependendo do local, é comum referir-se a espécies dos géneros Alocasia, Colocasia (taro), Xanthosoma e Ipomoea (batata-doce) também como inhame[2].[3][4][5]");
        break;
    default:
        Console.WriteLine("Inválido");
        break;
}
