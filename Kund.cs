

namespace Biograf
{
    public class Kund : Biljett
    {
        public string Epost { get; set; }
        private int PersonNummer;
        public virtual void BuyTicket()
        {
            Console.WriteLine($"{Epost} Du har köpt till biobiljett till {Titel}, som Kommer att sändas på {Day} den varar i {Längd} minuter, och du ska till salongsnummer {SalongNummer} din faktura blev på {Pris} kronor");
        }
    }

}
