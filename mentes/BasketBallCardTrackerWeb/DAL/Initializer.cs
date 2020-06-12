using BasketBallCardTrackerWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketBallCardTrackerWeb.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CardTrackerContext>
    {
        protected override void Seed(CardTrackerContext context)
        {
            List<User> users = new List<User>
            {
                new User { UserId=1 ,UserName="Jozsi", Email="asd@asd.hu", Password="asd" },
                new User { UserId=2 ,UserName="Feri", Email="asd@asd.hu", Password="asd" }
            };

            foreach (User user in users) { context.Users.Add(user); }
            context.SaveChanges();

            List<Collection> collections = new List<Collection>
            {
                new Collection { CollectionId=1, UserId=1, Name="Jordan" },
                new Collection { CollectionId=2, UserId=2, Name="LeBron" }
            };

            foreach (Collection collection in collections) { context.Collections.Add(collection); }
            context.SaveChanges();

            List<Card> cards = new List<Card>
            {
                new Card { CardId=1, CollectionId=1, Player="Michael Jordan" },
                new Card { CardId=2, CollectionId=2, Player="LeBron James" }
            };

            foreach (Card card in cards) { context.Cards.Add(card); }
            context.SaveChanges();
        }
    }
}
