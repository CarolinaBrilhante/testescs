using static System.Console;

public class Program
{
    static void Demo1()
    {
        int a = 2;
        a = Adicionar20(a);

        WriteLine($"O Valor da Variável é {a}");
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Carol";
        p1.Idade = 32;
        p1.Documento = "08092399492";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "Nala");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nomme de p2 é: {p2.Nome}
        ");
    }
    static void Demo3()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "9587",
            Idade = 20,
            Nome = "Lala"
        };

        var p2 = p1;
        
        p1 = TrocarNome(p1, "Lulu");

        WriteLine($@"
        Nome do p1 é: {p1.Nome}
        Nome do p2 é: {p2.Nome}
        ");
    }
    static void Demo4()
    {
        int[] pares = new int[] {0,2,4,6,8};

        MudarParaImpar(pares);
        WriteLine($"Os ímpares {string.Join("," , pares)}");

    }
    static void Demo5()
    {
        int [] numeros = new int [] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de envontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumeros(numeros,numero);

        if(idxEncontrado >= 0)
        {
            WriteLine($"O número encontrado está na posição {idxEncontrado}");
        }
        else
        {
            WriteLine("O número digitado não foi encontrado");
        }
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    static int EncontrarNumeros(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == numero)
            return i;
        }
        return -1;
    }
    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa )
    {
        foreach (var item in pessoas)
        {
            if(item.Nome == pessoa.Nome)
            {
                return true;
            }
            
        }
        return false;
    }
            
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Carol"},
            new Pessoa(){Nome = "Artur"},
            new Pessoa(){Nome = "Nala"},
            new Pessoa(){Nome = "Lulu"},
            new Pessoa(){Nome = "Lala"}
        };

        WriteLine("Digite a pessoa que gostaria de localizar:");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        
        if(encontrado)
        {
            WriteLine("Pessoa localizada!");

        }
        else
        {
            WriteLine("Pessoa não localizada!");
        }

    }
}