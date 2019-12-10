using System.Data.Entity;

namespace CRUD_mvc3.Models
{
    public class contexto: DbContext
    {
        public DbSet<equipamentos> Equipamentos { get; set; }
    }
}