namespace AppWebInstitut.Services
{
    public class ResponsiveService<T>
    {
        public T? Objeto {get; set; }
        public string? Error { get; set; } //Codigos de status HTML. Guardará la descripción del error
        public int Status { get; set; } //Numero de codigo de status.
        public bool Successful {get; set; } //Va a devolver un true cuando este todo bien.
    }

    //Métodos
    public ResponsiveService() //Este es el constructor, al ingresar una clase por defecto
    //esta todo ok, en caso de que no, empieza a devolver los errores.
    {
        status = 200; //Aceptar OK.
        successful= true;
    }
    public void AddBadRequest(string message)
    {
        Status = 400; //Argumento no valido o solicitud
        Error = message;
    }
    public void AddInternalServerError(string message)
    {
        status = 500; //Error de servidor interno
        Error = message;
    }
}