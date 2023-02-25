using System;
using Microsoft.EntityFrameworkCore;
using Tracking.Modals;

namespace Tracking.Data
{
	public class IssueDbContext : DbContext
	{
		public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options)
		{

		}

		public DbSet<Issue> Issues { get; set; }
	}
}

