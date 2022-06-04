using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace HMW_SQL_VS_Entity.FootballTeam
{
	public class League : DbContext
	{
		public DbSet<Club>? FootballClubs { get; set; }
		public DbSet<Player>? Players { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = localhost; Database = LeagueDB; User Id = sa; Password = Valuetech@123;");
		}

        public override string ToString()
        {
			return JsonSerializer.Serialize(this);
        }

       
	}
}

