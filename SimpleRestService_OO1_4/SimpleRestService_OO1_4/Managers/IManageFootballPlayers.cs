using System.Collections.Generic;

namespace SimpleRestService_OO1_4.Managers
{
    public interface IManageFootballPlayers
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int _id);
        bool Create(FootballPlayer value);
        bool Update(int _id, FootballPlayer value);
        FootballPlayer Delete(int _id);
    }
}
