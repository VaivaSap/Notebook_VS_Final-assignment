using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Notebook_VS_Final_assignment.Areas.Identity.Data;
using Notebook_VS_Final_assignment.Model;
using Notebook_VS_Final_assignment.Model.Repositories;

namespace Notebook_VS_Final_assignment.Areas.Identity.Data;

public class ContextNotebook : IdentityDbContext<Notebook_User, UserRole, Guid>
{
    public ContextNotebook(DbContextOptions<ContextNotebook> options)
        : base(options)
    {

    }

    public DbSet<ThoughtSnippets> Notes { get; set; }
    public DbSet<CategoriesForNotes> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Notebook_User>().HasMany(u => u.Categories).WithOne(c => c.Notebook_User);
        builder.Entity<CategoriesForNotes>().HasMany(u => u.NotesInCategory).WithOne(n => n.Category);
    }
}


