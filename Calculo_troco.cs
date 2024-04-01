using System; 

class URI {

    static void Main(string[] args) { 

    // ou decimal type
    double valorDigitado = double.Parse(Console.ReadLine());
    
    int centavos = Convert.ToInt32(valorDigitado * 100);
    
    double[] notas =  { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00 };
    double[] moedas = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };
    
    Console.WriteLine("NOTAS:");
    
    foreach (double nota in notas){
        
        int notaConvertida = Convert.ToInt32(nota * 100);
        int quantidadeDeNotas = centavos / notaConvertida;
        
        Console.WriteLine($"{quantidadeDeNotas} nota(s) de R$ {nota.ToString("0.00")}");
        
        centavos %= notaConvertida;
    }
    
    Console.WriteLine("MOEDAS:");
    
    foreach (double moeda in moedas){
        
        int moedaConvertida = Convert.ToInt32(moeda * 100);
        int quantidadeDeMoeda = centavos / moedaConvertida;
        
        Console.WriteLine($"{quantidadeDeMoeda} moeda(s) de R$ {moeda.ToString("0.00")}");
        
        centavos %= moedaConvertida;
    }
    
    
    
}
}
