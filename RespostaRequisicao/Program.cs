// See https://aka.ms/new-console-template for more information
using RespostaRequisicao;

Console.WriteLine("Requisicao Resposta");

Conta conta = new Conta("Ricardo", 100_000.00);

Console.WriteLine("\nXML =======");
Requisicao xml = new Requisicao(Formato.XML);
CadeiaDeFormato.RespondeFormato(xml,conta);

Requisicao csv = new Requisicao(Formato.CSV);
Console.WriteLine("\nCSV =======");
CadeiaDeFormato.RespondeFormato(csv,conta);

Console.WriteLine("\nPOR CENTO =======");
Requisicao porcento = new Requisicao(Formato.PORCENTO);
CadeiaDeFormato.RespondeFormato(porcento,conta);

Console.WriteLine("\nJSON =======");
Requisicao json = new Requisicao(Formato.JSON);
CadeiaDeFormato.RespondeFormato(json,conta);

Console.WriteLine("\nHTML =======");
Requisicao html = new Requisicao(Formato.HTML);
CadeiaDeFormato.RespondeFormato(html, conta);


Console.ReadKey();

