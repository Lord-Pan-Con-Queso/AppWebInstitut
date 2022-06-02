using System.ComponentModel.DataAnnotations;
namespace AppWebInsitut.DataAccess.Modelos
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public string? LocalidadName { get; set; }
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]    
        public string? CodPost { get; set; }
        //Clave Foránea
        public int ProvinciaId { get; set; }
        [DataType(DataType.Date) ]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime DateUpdate { get; set; }
    }
}