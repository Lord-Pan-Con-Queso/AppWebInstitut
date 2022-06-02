using System.ComponentModel.DataAnnotations;
namespace AppWebInsitut.DataAccess.Modelos
{
    public class Provincia
    {
        public int ProvinciaID { get; set; }
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public string? ProvinciaName { get; set; }
        [DataType(DataType.Date) ]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime DateUpdate { get; set; }
    }
}