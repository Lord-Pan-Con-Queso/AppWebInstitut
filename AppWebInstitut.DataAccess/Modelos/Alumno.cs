using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Alumno
    {
//Atributos
        public int AlumnoId { get; set; }
        //El signo de interrogación despues de string indica que la propiedad acepta valores nulos.
        //Otra forma de indicar esto es poner al final una asignación null!
        //Ej.: public string? Nombre {get, set}
        //Ej.: public string Nombre {get, set} = null!
        //Tambien podemos guardar la propiedad como vacia.
        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        public string? Nombre { get; set; }
        [StringLength(45, ErrorMessage = "El largo máximo es de 45 caracteres")]
        public string? Apellido { get; set; }
        [StringLength(8, MinimumLength =8, ErrorMessage = "Inserte un número de documento válido")]
        [RegularExpression(@"^[0-9]{7,8}")]
        public string? NroDoc { get; set; }
        //Esto es para que el daratime me muestre solo la fecha y no la hora.
        [DataType(DataType.Date) ]
        //Esto es para decirle cómo quiero que me muestre la fecha
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        //DateTime para fechas
        public DateTime FechaNac { get; set; }
        //Domicilio es una composición
        public Domicilio? Domicilio { get; set; }
        //Clave foranea
        public int ProvinciaId { get; set; }
        //Clave foranea
        public int LocalidadId { get; set; }
        [StringLength(15, MinimumLength =10, ErrorMessage = "Inserte un número de teléfono válido")]
        [RegularExpression(@"^[0-9]{10,15}")]
        public string? NroTel { get; set; }
        [StringLength(15, MinimumLength =10, ErrorMessage = "Inserte un número de teléfono movil válido")]
        public string? NroMovil { get; set; }
        [RegularExpression (@"^[a-zA-Z0-9]+(\.{0,1}[a-zA-Z]+)*@(hootmail|yahoo|outlook|gmail){1}\.{1}[a-z]{3}(\.[a-z]{0,2}){0,1}$",ErrorMessage = "El correo no es válido.")]
        public string? EMail { get; set; }
        [StringLength (5, ErrorMessage = "Inserte un número válido.")]
        [RegularExpression(@"^[0-9{7,8}]")]
        public int Legajo { get; set; }
        //Si Eliminado está en true está eliminado y si está en false está activo.
        //De esta forma se hace un borrado lógico.
        public bool Eliminado { get; set; }
        //Para saber cuando se actualizan los datos.
        [DataType(DataType.Date) ]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime DateUpdate { get; set; }
        //Localidad y provincia son agregaciones, si se destruye el obejto alumon siguen existiendo.
        //Domicilio es una composición, porque si destruyo el objeto alumno se destruye el domicilio tambien

//Métodos
        public string FullName(){
            return Apellido + " " + Nombre;
        }
    }
}