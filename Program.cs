using System;
using static System.Console;

WriteLine("Bem-vindo à soma e média!");
SomaEMedia sm = new SomaEMedia();
List<double> numeros = new List<double>();



while (true)
{
    s
    string qtd = sm.QuantidadeInput(numeros);
    sm.Conversao(qtd);
    sm.MontarLista(numeros, sm.Quantidade);
    sm.CalcularSoma(numeros);
    sm.Resultado = sm.CalcularMedia(sm.Soma, sm.Quantidade);
    sm.MostrarResultado(sm.Resultado);
    numeros.Clear();
}

public class SomaEMedia
{
    public int Quantidade { get; set; }
    public double Soma { get; set; }
    public string Media { get; set; }
    public double Resultado { get; set; }

    public string QuantidadeInput(List<double> lista)
    {
        WriteLine("Quantos números deseja calcular a média? (3 a 10)");
        Write("Quantidade: ");
        string quantidade = ReadLine();
        return quantidade;
    } 
        public void Conversao(string quantidade, List<double> lista)
    {
        if (!int.TryParse(quantidade, out int qtd))
        {
            MensagemDeErro();
            return;
        }

        Quantidade = qtd;
        Verificacao(qtd, lista);
        
    }

    public void Verificacao(int quantidade, List<double> lista)
    {
        if (quantidade < 3 || quantidade > 10)
        {
            WriteLine("Erro, digite um número entre 3 e 10");
            WriteLine("Pressione ENTER para voltar ao menu...");
            ReadLine();
        }
       
    }

    public void MensagemDeErro()
    {
        WriteLine("Erro, digite um número entre 3 e 10");
        WriteLine("Pressione ENTER para voltar ao menu...");
        ReadLine();
    }

    public void MostrarResultado(double resultado)
    {
        
        WriteLine("Média: " +resultado.ToString("F2"));
        WriteLine("Pressione ENTER para sair");
        ReadLine();
        Sair();
       
        
    }
    public void Sair()
    {
        WriteLine("Saindo...");
        Environment.Exit(0);

    }


    public void MontarLista(List<double> lista, int quantidade)
        {
            for(int i = 0; i < quantidade; i++)
        {
            Write("Digite um número: ");

            if (double.TryParse(ReadLine(), out double n))
            {
                lista.Add(n);
            }
            else
            {
                WriteLine("Número inválido");
                i--;
            }
        }
            
            
        }

    public void CalcularSoma(List<double> lista)
    {
        Soma = 0;
        foreach(double n in lista)
        {
            Soma += n;
        }
    }

    public double CalcularMedia(double soma, int quantidade)
    {
        return soma / quantidade;
    }
        
}