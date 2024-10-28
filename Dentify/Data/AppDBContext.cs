using Dentify.Models;
using Microsoft.EntityFrameworkCore;

namespace Dentify.Data;

public class AppDBContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public AppDBContext(DbContextOptions<AppDBContext> options): base(options){
    }
}