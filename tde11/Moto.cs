public class Moto : Veiculo{
    private bool TemBagageiro;

    public Moto(string marca, string modelo, int ano, bool TemBagageiro)
    :base(marca, modelo, ano)
    {
        this.TemBagageiro = TemBagageiro;

    }

    public void DarGrau(){
        Console.WriteLine("ramdamdamdam");
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"{Marca}, {Modelo}, {Ano}, {TemBagageiro}");
    
    }

    public void Desligar(){
        Console.WriteLine("A moto está desligada");
    }
}