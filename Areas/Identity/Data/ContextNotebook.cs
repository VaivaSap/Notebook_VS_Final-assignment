using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Notebook_VS_Final_assignment.Areas.Identity.Data;
using Notebook_VS_Final_assignment.Model;

namespace Notebook_VS_Final_assignment.Areas.Identity.Data;

public class ContextNotebook : IdentityDbContext<Notebook_User>
{
    public ContextNotebook(DbContextOptions<ContextNotebook> options)
        : base(options)
    {

    }

public DbSet<ThoughtSnippets>  Notes { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
    }
}
