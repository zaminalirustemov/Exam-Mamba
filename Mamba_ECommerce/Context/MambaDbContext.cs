using Mamba_ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Mamba_ECommerce.Context;
public class MambaDbContext:DbContext
{
	public MambaDbContext(DbContextOptions<MambaDbContext> options) : base(options) { }

	public DbSet<Position> Positions { get; set; }
	public DbSet<Team> Teams { get; set; }
}
