using Microsoft.EntityFrameworkCore;
using AppWebInstitut.DataAccess.Modelos;

namespace AppWebInsitut.DataAccess.Data
{
    //DbContext pertenece a EntityFrameworkCore
    public class InstitutContext:DbContext
    {
        //A la calse DbContext le voy a pasar un parametro llamado options. Cuando instancie el 
        //objeto institut context le voy a tener que pasar la informacion de quien es la base de datos
        public InstitutContext(DbContextOptions <InstitutContext> options):base(options)
        {

        }

        //Tablas de la base de datos. Son propiedades
        //DbSet establece la relacion entre la tabla de la DB y el modelo utilizado
        //en mi progama.
        public DbSet<Alumno>? Alumnos {get; set; }
        public DbSet<Domicilio>? Domicilios { get; set; }
        public DbSet<Localidad>? Localidades { get; set; }
        public DbSet<Provincia>? Provincias { get; set; }
        public DbSet<AlumnoXAsignatura>? AlumnoxAsignaturas {get; set; }
        public DbSet<Cursado>? cursados { get; set; }
        public DbSet <Curso>? cursos { get; set; }
        public DbSet <DocentesXAsignatura>? docentesXAsignaturas { get; set; }
        public DbSet<Docente>? Docentes{get;set;}
        public DbSet<DocentesXAsignatura>? DocentesXAsignaturas{get;set;}
        public DbSet<Resoluciones>? Resoluciones{get;set;}
        public DbSet<TipoAsignatura>? TipoAsignaturas{get;set;}


    }
}
