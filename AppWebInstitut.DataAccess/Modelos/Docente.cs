using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Docente
    {
        public int DocenteId{get;set;}

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public string? Legajo{get;set;}

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? NombreDocente{get;set;}

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? ApellidoDocente{get;set;}

        [StringLength(3,MinimumLength =3,ErrorMessage ="DNI cuenta con 8 numeros")]
        [RegularExpression(@"^[0-9]")]
        public int DNI{get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [RegularExpression(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$")]
        public DateTime FechaNacimiento{get;set;}

        public int provincia{get;set;}

        public int localidad{get;set;}

        [StringLength(10,MinimumLength =10,ErrorMessage ="Ingrese su teléfono sin 15")]
        public string? NroTelefono{get;set;}

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z0-9]+(\.{1}[a-zA-Z0-9]+)*@(hotmail|yahoo|outlook|gmail){1}\.{1}[a-z]{3}(\.[a-z]{0,2}){0,1}$")]
        public string? EMail{get;set;}

        [StringLength(50,MinimumLength =10,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public int domicilio{get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [RegularExpression(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$")]
        public bool Estado{get;set;}
    }
}