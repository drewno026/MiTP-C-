namespace ZadanieDomowe_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document identityCard = new Document("Kapela", "Pilaka", EyeColor.Brown, 2025);
            Console.WriteLine(identityCard.FirstName);
            Console.WriteLine(identityCard.LastName);
            Console.WriteLine(identityCard.EyeColor);
            Console.WriteLine(identityCard.ExpirationDate);
            Document studentCard = new Document("Jan", "Kowalski", EyeColor.Green, 2020);
            Wallet myWallet = new Wallet
            {
                IdentityCard = identityCard,
                StudentCard = studentCard
            };
            int currentYear = DateTime.Now.Year;
            myWallet.CheckDate(currentYear);
        }
    }
}
