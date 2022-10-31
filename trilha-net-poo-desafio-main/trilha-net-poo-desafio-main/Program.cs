using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program 
{
    public static void Main(string[] args)
    {
        Nokia n1 = new Nokia("10", "g10", "215432q5", 16);
        Iphone a1 = new Iphone("120", "12x", "43gbasdfg343", 128);
        
        n1.ReceberLigacao();
        n1.Ligar();
        n1.InstalarAplicativo("Telegram");
        a1.Ligar();

        a1.InstalarAplicativo("WhatsApp");




    }
}
