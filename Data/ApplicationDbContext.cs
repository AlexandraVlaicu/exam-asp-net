using ex.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ex.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
}
    public DbSet<Actor> Actori { get; set; }
    public DbSet<Film> Filme { get; set; }
    public DbSet<ActorFilm> ActorFilme{ get; set; }
}

