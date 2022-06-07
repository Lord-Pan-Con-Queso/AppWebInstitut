using AppWebInsitut.DataAccess.Modelos;
using AppWebInstitut.DataAccess.Modelos;
namespace AppWebInstitut.Services
{
    public interface IAlumnosService
    {
        //Devolverá el listado de alumnos.
        Task<ResponsiveService<List<Alumno>>> Listar();
        //Buacara a los alumnos por id, el BuscarPorId recibirá idalumno.
        Task<ResponsiveService<Alumno>> BuscarPorId(int id);
        Task<ResponsiveService<Alumno>> Guardar(Alumno alumno);
        Task<ResponsiveService<Alumno>> Actualizar (Alumno alumno);
        Task<ResponsiveService<bool>> Eliminar (int id);

    }
}