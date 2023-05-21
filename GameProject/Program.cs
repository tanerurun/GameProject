using GameProject.Concrete;
using GameProject.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player()
        {
            Id = 1,
            FirstName = "Taner",
            LastName="Urun",
            NationalNumber=38848
          
        };

        Game game = new Game()
        {
            Id= 2,
            Description="2023 Call of Dutcy",
            GameName="World of War",
            GamePrice=200
            
        };


        Offer offer = new Offer()
        {
            Id = 1,
            OfferDescription="Haziran Kampanyasi",
            OfferDiscountRate=10,
            OfferName="Hazirana ozel kampanya"
        };

        PlayerManager playerManager = new PlayerManager(new RealCheckPlayerManager());
       //playerManager.Add(player);
       // playerManager.Delete(player);
       //  playerManager.Update(player);


        GameManeger gameManager = new GameManeger();
        gameManager.Sale(player, game);


        OfferManager offerManager = new OfferManager();
        offerManager.Add(offer, game);
        offerManager.Delete(offer, game);
        offerManager.Upgrade(game, offer);


        Console.ReadLine();
    }
}