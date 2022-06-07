using System.ComponentModel.DataAnnotations;
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Curso
    {
        public int CursoId{get;set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public string? anioCurso{get;set;}
        [StringLength(1,MinimumLength =5,ErrorMessage ="El largo máximo es de 5 caracteres")]
        public string? division{get;set;}
    }
}