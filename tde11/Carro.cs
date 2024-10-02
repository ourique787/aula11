public class Carro : Veiculo {
    private int numeroDePortas;

    public Carro(int numDePortas, string marca, string modelo, int ano)
    :base(marca, modelo, ano)
    {
        numeroDePortas = numDePortas;

    }

    public void AbrirPortaMalas(){
        Console.WriteLine("O porta-malas está aberto");
    }

    public void Ligar(){
        Console.WriteLine("O carro está ligando");
    }

    public void Desligar(){
        Console.WriteLine("O carro está desligando");
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"{Marca}. {Modelo}, {Ano}, {numeroDePortas}");

    }

}