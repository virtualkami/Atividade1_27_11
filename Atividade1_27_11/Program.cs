namespace Atividade1_27_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cria uma variável do tipo string denominada linhas e insere o conteúdo dentro
            string linhas = @"Esta é a linha 1
            Esta é a linha 2
            A penúltima é a linha 3
            A última é a linha 4";
            // criação da string item
            string item;
            // bloco using recebendo e lendo o conteúdo da string linhas
            using (var leitor = new StringReader(linhas)){ 
            // bloco do while e item recebendo leitor
                do{item = leitor.ReadLine();
            // escrever linhas
                    Console.WriteLine(linhas);
            // o bloco para se item for nulo
                } while (item != null);}
        }
    }
}
