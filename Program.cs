namespace Biograf
{
    public class Program
    {
        static void Main(string[] args)
        {

            Kund Thor = new Kund();
            Thor.Titel = "Matrix";
            Thor.Längd = 120;
            Thor.Day = "Söndag";
            Thor.SalongNummer = 4;
            Thor.Pris = 170;
            Thor.Epost = "Thor@hammaren.com";
            Thor.BuyTicket();
            
        }
    }
}
