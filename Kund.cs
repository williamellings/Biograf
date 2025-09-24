

namespace Biograf
{
    public class Kund : Visning
    {
        public object Pris { get; private set; }

        public virtual void BuyTicket()
        {
            Console.WriteLine($"Du har köpt till filmen {Titel}, som Kommer att sändas på {Day} den varar i {Längd} minuter, och du ska till salongsnummer {SalongNummer} din faktura blev på {Pris} kronor");
        }
    }

}
