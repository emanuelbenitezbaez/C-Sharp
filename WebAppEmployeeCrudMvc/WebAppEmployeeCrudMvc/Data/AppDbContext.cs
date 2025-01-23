using Microsoft.EntityFrameworkCore;
using WebAppEmployeeCrudMvc.Models;
namespace WebAppEmployeeCrudMvc.Data
{
    // Esta clase define el contexto de base de datos de la aplicación
    public class AppDbContext : DbContext
    {
        // Constructor que recibe opciones para configurar el contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define un conjunto de datos (tabla) para la entidad Employee
        public DbSet<Employee> Employees { get; set; }

        // Método para configurar detalles adicionales de las entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define la configuración de la entidad Employee
            modelBuilder.Entity<Employee>(table =>
            {
                // Define la clave primaria de la entidad Employee
                table.HasKey(col => col.IdEmployee);

                // Configura la propiedad IdEmployee para que
                // sea una columna de identidad (auto incremental)
                table.Property(col => col.IdEmployee)
                    .UseIdentityColumn()
                    .ValueGeneratedOnAdd();

                // Configura la propiedad FullName con un máximo de 50 caracteres
                table.Property(col => col.FullName).HasMaxLength(50);
            });

            // Especifica que la entidad Employee debe mapearse a la tabla "Employee"
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }


}
