using System;

class Program
{
    static void Main()
    {
        Saudacao.ExibirSaudacao();

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja bem-vindo ao programa de exercícios!\n");

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calcular Idade");
            Console.WriteLine("2 - Registro de Doações");
            Console.WriteLine("3 - Conversor Milhas -> KM");
            Console.WriteLine("4 - Conversor Minutos -> Horas");
            Console.WriteLine("5 - Cálculo de Área de Terreno");
            Console.WriteLine("6 - Sistema de Boletim Escolar");
            Console.WriteLine("7 - Gerenciamento de Carga");
            Console.WriteLine("8 - Jogo de Combate");
            Console.WriteLine("9 - Cálculo de Aumento Salarial");
            Console.WriteLine("10 - Cálculo de Área e Perímetro de Círculo");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Exercicio1.CalcularIdade();
                    break;

                case "2":
                    Exercicio2.VerificacaoDeDeposito();
                    break;

                case "3":
                    Exercicio3.ConverterMilhasParaKm();
                    break;

                case "4":
                    Exercicio4.ConverterMinutos();
                    break;

                case "5":
                    Exercicio5.CalcularAreaTerreno();
                    break;

                case "6":
                    Exercicio6.CalcularMediaNotas();
                    break;

                case "7":
                    Exercicio7.CalcularVeiculosNecessarios();
                    break;

                case "0":
                    continuar = false;
                    Console.WriteLine("Encerrando o programa... Até logo!");
                    break;

                case "8":
                    Exercicio8.JogoDeCombate();
                    break;

                case "9":
                    Exercicio9.CalcularAumentoSalarial();
                    break;

                case "10":
                    Exercicio10.CalcularAreaPerimetroCirculo();
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            Console.WriteLine();

            if (continuar)
            {
                Console.WriteLine("Pressione ENTER para voltar ao menu anterior...");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}

class Saudacao
{
    public static void ExibirSaudacao()
    {
        Console.WriteLine(@"
 _    _ _____ _     _____ ________  ___ _____ 
| |  | |  ___| |   /  __ \  _  |  \/  ||  ___|
| |  | | |__ | |   | /  \/ | | | .  . || |__  
| |/\| |  __|| |   | |   | | | | |\/| ||  __| 
\  /\  / |___| |___| \__/\ \_/ / |  | || |___ 
 \/  \/\____/\_____/\____/\___/\_|  |_/\____/ 
                                              
                                              ");
    }
}

class Exercicio1
{
    public static void CalcularIdade()
    {
        Console.WriteLine("=== Cálculo de idade ===\n");

        Console.Write("Digite o ano do seu nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int anoAtual = DateTime.Now.Year;
        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"Sua idade é de {idade} anos.");
    }
}

class Exercicio2
{
    public static void VerificacaoDeDeposito()
    {
        Console.WriteLine("=== Registro de Doação ===\n");

        Console.Write("Digite o valor da doação (ex: 500): ");
        double valorRecebido = double.Parse(Console.ReadLine());

        Console.Write("A doação é anônima? (sim/não): ");
        string respostaAnonima = Console.ReadLine().Trim().ToLower();
        bool doacaoAnonima = (respostaAnonima == "sim");

        Console.Write("Digite o tipo de conta (P para poupança / C para corrente): ");
        char tipoConta = char.Parse(Console.ReadLine().Trim().ToUpper());

        Console.WriteLine("\n=== Dados da Doação ===");
        Console.WriteLine($"Valor recebido: R${valorRecebido}");
        Console.WriteLine($"Doação anônima: {doacaoAnonima}");
        Console.WriteLine($"Tipo de conta: {tipoConta}");

    }
}

class Exercicio3
{
    public static void ConverterMilhasParaKm()
    {
        Console.WriteLine("=== Conversor de Milhas para Quilômetros ===\n");

        Console.Write("Digite a distância em milhas: ");
        double milhas = double.Parse(Console.ReadLine());

        double quilometros = milhas * 1.60934;

        Console.WriteLine($"{milhas} milhas equivalem a {quilometros} quilômetros.");
    }
}

class Exercicio4
{
    public static void ConverterMinutos()
    {
        Console.WriteLine("=== Conversor de Minutos para Horas ===\n");

        Console.Write("Digite o total de minutos: ");
        int minutos = int.Parse(Console.ReadLine());

        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;

        Console.WriteLine($"Tempo: {horas} horas e {minutosRestantes} minutos.");
    }
}

class Exercicio5
{
    public static void CalcularAreaTerreno()
    {
        Console.WriteLine("=== Cálculo da Área de Terreno Retangular ===\n");

        Console.Write("Digite a largura do terreno (em metros): ");
        double largura = double.Parse(Console.ReadLine());

        Console.Write("Digite o comprimento do terreno (em metros): ");
        double comprimento = double.Parse(Console.ReadLine());

        double area = largura * comprimento;

        Console.WriteLine($"\nA área do terreno é: {area:F2} metros quadrados.");
    }
}

class Exercicio6
{
    public static void CalcularMediaNotas()
    {
        Console.WriteLine("=== Sistema de Boletim Escolar ===\n");

        Console.Write("Digite a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"\nA média das notas é: {media:F1}");
    }
}

class Exercicio7
{
    public static void CalcularVeiculosNecessarios()
    {
        Console.WriteLine("=== Gerenciamento de Carga ===\n");

        Console.Write("Digite o peso total dos containers (em toneladas): ");
        decimal pesoTotal = decimal.Parse(Console.ReadLine());

        int veiculosNecessarios = (int)pesoTotal;

        Console.WriteLine($"\nVeículos necessários: {veiculosNecessarios}");
    }
}
class Exercicio8
{
    public static void JogoDeCombate()
    {
        Console.WriteLine("=== Jogo de Combate ===\n");

        // Jogador começa com 3 vidas
        int vidas = 2;
        Random rng = new Random();

        for (int rodada = 1; rodada <= 3; rodada++)
        {
            Console.WriteLine($"\n--- Rodada {rodada} ---");
            Console.Write("Escolha sua ação (A = atacar / D = defender): ");
            string acao = Console.ReadLine().Trim().ToUpper();

            Console.Write("Digite o número do seu dado (1 a 12): ");
            int dadoJogador = int.Parse(Console.ReadLine());

            int dadoSistema = rng.Next(1, 13);

            if (acao == "A")
                Console.WriteLine("Você atacou e o sistema defendeu!");
            else if (acao == "D")
                Console.WriteLine("Você defendeu e o sistema atacou!");
            else
                Console.WriteLine("Ação inválida, considerando defesa...");

            Console.WriteLine($"Seu dado: {dadoJogador} | Dado do sistema: {dadoSistema}");

            if (dadoJogador > dadoSistema)
            {
                vidas++;
                Console.WriteLine("Você venceu a rodada! +1 vida.");
            }
            else if (dadoJogador < dadoSistema)
            {
                vidas--;
                Console.WriteLine("Você perdeu a rodada! -1 vida.");
            }
            else
            {
                Console.WriteLine("Empate! Nenhuma vida alterada.");
            }

            Console.WriteLine($"Vidas atuais: {vidas}");
        }

        // Resultado final
        Console.WriteLine("\n=== Fim do jogo ===");
        if (vidas > 0)
            Console.WriteLine($"Você sobreviveu com {vidas} vidas. Vitória!");
        else
            Console.WriteLine("Suas vidas acabaram. ❌ Derrota!");
    }
}

class Exercicio9
{
    public static void CalcularAumentoSalarial()
    {
        Console.WriteLine("=== Cálculo de Aumento Salarial ===\n");

        Console.Write("Digite o salário atual: R$");
        decimal salarioAtual = decimal.Parse(Console.ReadLine());

        Console.Write("Digite o percentual de aumento (%): ");
        decimal percentualAumento = decimal.Parse(Console.ReadLine());

        decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100);

        Console.WriteLine($"\nO novo salário é de R${novoSalario.ToString("F2")}");
    }
}

class Exercicio10
{
    public static void CalcularAreaPerimetroCirculo()
    {
        Console.WriteLine("=== Cálculo de Área e Perímetro de Círculo ===\n");

        double pi = 3.14159;

        Console.Write("Digite o valor do raio do círculo: ");
        double raio = double.Parse(Console.ReadLine());

        double area = pi * raio * raio;

        double perimetro = 2 * pi * raio;

        Console.WriteLine($"\nRaio: {raio.ToString("F2")}");
        Console.WriteLine($"Área do círculo: {area.ToString("F2")}");
        Console.WriteLine($"Perímetro do círculo: {perimetro.ToString("F2")}");
    }
}