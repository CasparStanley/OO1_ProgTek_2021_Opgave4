using System.Collections.Generic;

namespace SimpleRestService_OO1_4.Managers
{
    public class ManageFootballPlayers : IManageFootballPlayers
    {
        private static List<FootballPlayer> players = new List<FootballPlayer>()
        {
            new FootballPlayer(0, "Jesper Grønkjær", 50000, 10),
            new FootballPlayer(1, "Jesper Kristiansen", 20000, 1),
            new FootballPlayer(2, "Kasper Schmeicel", 100000, 9),
            new FootballPlayer(3, "Fodboldspiller Fire", 40000, 99),
            new FootballPlayer(4, "En mere", 59000, 69),
        };

        public bool Create(FootballPlayer newPlayer)
        {
            players.Add(newPlayer);
            return true;
        }

        public FootballPlayer Delete(int _id)
        {
            // Get the FootballPlayer we want to delete
            FootballPlayer fP = Get(_id);

            // Remove it from the list of FootballPlayers
            players.Remove(fP);

            return fP;
        }

        public IEnumerable<FootballPlayer> Get()
        {
            // Return the list of FootballPlayers
            return new List<FootballPlayer>(players);
        }

        public FootballPlayer Get(int _id)
        {
            // Find the FootballPlayer by their _id
            return players.Find(i => i.Id == _id);
        }

        public bool Update(int _id, FootballPlayer player)
        {
            // Get the FootballPlayer we want to modify
            FootballPlayer fP = Get(_id);

            // Update all the values in fP with the values provided by player
            if (fP != null)
            {
                fP.Id = player.Id;
                fP.Name = player.Name;
                fP.Price = player.Price;
                fP.ShirtNumber = player.ShirtNumber;

                return true;
            }

            return false;
        }
    }
}
