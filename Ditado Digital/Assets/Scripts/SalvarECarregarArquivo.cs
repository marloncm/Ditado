using System;
using System.IO;
using UnityEngine;

// Classe com os dados que serão salvos
/*
public class DadosSalvar
{
    public int Fase;
    public bool TutorialCompleto = false;
    public int Pontuacao;
    public int Erros;
}
*/

/*
public static class SalvarECarregarArquivo
{
    public int Fase;
    public bool TutorialCompleto = false;
    public int Pontuacao;
    public int Erros;





    private static string caminhoArquivo = "Assets/teste.txt"; // Caminho do arquivo .txt no projeto

    // Função para salvar os dados no arquivo .txt
    public static void SalvarTXT(DadosSalvar dados)
    {
        StreamWriter writer = new StreamWriter(caminhoArquivo, true);
        writer.WriteLine(dados.Fase);
        writer.WriteLine(dados.Pontuacao);
        writer.WriteLine(dados.TutorialCompleto);
        writer.WriteLine(dados.Erros);

        writer.Flush(); // Descarrega arquivo da memória
        writer.Close(); // Fecha o arquivo
    }

    // Função para carregar os dados no arquivo .txt
    public static void CarregarTXT(DadosSalvar dados)
    {
        try // Tentativa para acessar o arquivo de salvo
        {
            StreamReader reader = new StreamReader(caminhoArquivo);

            dados.Fase = int.Parse(reader.ReadLine());
            dados.Pontuacao = int.Parse(reader.ReadLine());
            dados.TutorialCompleto = bool.Parse(reader.ReadLine());
            dados.Erros = int.Parse(reader.ReadLine());

            reader.Close(); // Fecha o arquivo
        }
        catch (Exception e) // Se acontecer algum erro
        {
            Debug.Log("Arquivo de save não existe.");
            Debug.Log(e.Message);
        }
    }
        
    // Função para apagar arquivo .txt
    public static void DeleteFile()
    {
        TutorialCompleto = false;
        File.Delete(caminhoArquivo);
    }
}

//*/