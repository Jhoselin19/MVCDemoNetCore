using Microsoft.EntityFrameworkCore;

namespace MVCDemoNetCore.Models
{
    public class SchoolContext :DbContext
    {

        //tabla de la base de datos
        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        //cadena de conexion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-19VR9K1O\\SQLEXPRESS;Initial Catalog=SchoolBD; User id=user01; Pwd=123456;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
