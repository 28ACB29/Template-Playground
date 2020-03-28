using System.Data.Entity;

namespace TemplatePlayground.Models
{
	public class TestDB : DbContext
	{
		public DbSet<Test> Tests
		{
			get;
			set;
		}
	}
}