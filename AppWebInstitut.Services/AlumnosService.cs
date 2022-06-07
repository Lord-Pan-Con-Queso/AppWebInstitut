using AppWebInsitut.DataAccess.Modelos;
using AppWebInstitut.DataAccess.Modelos;

namespace AppWebInstitut.Services
{
    public class AlumnosServices : IAlumnosService
    {
        public Task<ResponsiveService<Alumno>> Actualizar(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsiveService<Alumno>> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsiveService<bool>> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsiveService<Alumno>> Guardar(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsiveService<List<Alumno>>> Listar()
        {
            throw new NotImplementedException();
        }
    }
}