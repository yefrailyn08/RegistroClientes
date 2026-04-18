using Microsoft.EntityFrameworkCore;
using RegistroClientes.Data.Models;

namespace RegistroClientes.Data.Context;

public class ClienteDbContext : DbContext
{
    public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; } = null!;
}