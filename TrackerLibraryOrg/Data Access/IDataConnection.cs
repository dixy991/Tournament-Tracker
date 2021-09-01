using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibraryOrg.Models;

namespace TrackerLibraryOrg.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreatePerson(PersonModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        List<PersonModel> GetPersonAll();
        List<TeamModel> GetTeamAll();
        List<PrizeModel> GetPrizeAll();
        List<TournamentModel> GetTournamentAll();
    }
}
