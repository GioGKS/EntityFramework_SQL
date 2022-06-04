using System;
using Microsoft.EntityFrameworkCore;

namespace HMW_SQL_VS_Entity.FootballTeam
{
	public class CreatePlayer
	{
		League leagueContext { get; set; }

		public CreatePlayer()
        {
			leagueContext = new();
        }

		public void OpeningHelpList()
        {
			Console.WriteLine("Hello! Please Choose One Of This Options: ");
			Console.WriteLine("OPTION 1: Create Entity.");
			Console.WriteLine("OPTION 2: Delete Entity.");
			Console.WriteLine("OPTION 3: Update Entity.");
			Console.WriteLine("OPTION 4: Get Entity Details.");
			Console.WriteLine("OPTION 5: Get List Of Entities.\n");
		}

		//Functions By Order Of Client
		//1) Create An Entity
		public void CreateEntity()
		{
			//Asking client For Club Names:
			Console.WriteLine("Please Enter Name Of Your Football Club > > > > > ");
			string footClub = Console.ReadLine();
            Console.WriteLine("");
			

			var FootballLeague = new League();
			var Clubs = new List<string> { footClub }.Select(x => new Club() { ClubName = x }).ToList();
			FootballLeague.FootballClubs.AddRange(Clubs);

			//Asking client For Player Names:
			Console.WriteLine("Please Enter 3 Names Of Your Football Players > > > > >");
            Console.WriteLine("First Player: ");
			string firstPlayer = Console.ReadLine();
			Console.WriteLine("Second Player: ");
			string secondPlayer = Console.ReadLine();
			Console.WriteLine("Third Player: ");
			string thirdPlayer = Console.ReadLine();

			var PlayerNames = new List<string> { firstPlayer, secondPlayer, thirdPlayer }.Select(x => new Player() { PlayerName = x }).ToList();
			FootballLeague.Players.AddRange(PlayerNames);

			FootballLeague.SaveChanges();
		}


		//2)Delete An Entity
		public void DeleteEntity()
		{
			Console.WriteLine("Please Enter ID Of Player You Would Like To Delete In current Entity:");
			int ChoosenID = int.Parse(Console.ReadLine());

			using (var FootballLeague = new League())
			{
				FootballLeague.Remove(FootballLeague.Players.Single(x => x.PlayerId == ChoosenID));
				FootballLeague.SaveChanges();
				Console.WriteLine("* * * * * * * * Your Choosen Data Has Been Deleted! * * * * * * * *");
			}
		}


		//3)Update An Entity
		public void UpdateEntity()
		{

			Console.WriteLine("Please Choose ID Of Player You Would Like To Update: ");
			int choosenId = int.Parse(Console.ReadLine());
			if (choosenId == null)
			{
				Console.WriteLine("Please Enter Valid Number: ");
			}

			var FootballLeague = new League();
			var result = FootballLeague.Players.SingleOrDefault(x => x.PlayerId == choosenId);
			Console.WriteLine("Please Choose New Name For Player:");
			result.PlayerName = Console.ReadLine();

			FootballLeague.SaveChanges();
            Console.WriteLine("* * * * * * * * Name Has Been Updated * * * * * * * *");


		}


		//4)Get Entity Details
		public void EntityDetails()
		{
			Console.WriteLine("Details Of Which Player Would You Like To See?");
			int playerId = int.Parse(Console.ReadLine());

			var leaguePlayer = new League();
			var choosenPlayer = leaguePlayer.Players.Select(x => x.PlayerId == playerId);
			foreach (var name in leaguePlayer.Players.Select(x => x.PlayerName))
			{
				Console.WriteLine(name);
			}

			leaguePlayer.SaveChanges();
		}

		//5)Get the List of entities
		public void ListOfEntities()
		{
			var leaguePlayer = new League();
			DbSet<Player> allEntities = leaguePlayer.Set<Player>();
			foreach (Player player in allEntities)
			{
				Console.WriteLine($"{player.PlayerId} = {player.PlayerName}");
            }
			leaguePlayer.SaveChanges();
		}
	}
}

