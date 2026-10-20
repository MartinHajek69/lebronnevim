namespace Strategy
{
    public class PlatbaHotove : IStrategie
    {
        public void Zaplatit(decimal castka)
        {
          Console.WrtiteLine($"Platba kartou {castka} Kč.");  
        }
    }
}