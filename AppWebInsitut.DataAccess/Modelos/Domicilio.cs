using System.ComponentModel.DataAnnotations;
namespace AppWebInsitut.DataAccess.Modelos
{
    public class Domicilio
    {
        public int DomicilioId { get; set; }
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public string? Calle { get; set; }
        public int Numero { get; set; }
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public string? Departamento { get; set; }
        public int Piso { get; set; }
        [StringLength(50, ErrorMessage = "El largo máximo es de 50 caracteres")]
        public string? Barrio { get; set; }
        [StringLength(15, ErrorMessage = "El largo máximo es de 15 caracteres")]
        public string? Manzana { get; set; }
        public int Casa { get; set; }
        [DataType(DataType.Date) ]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime DateUpdate { get; set; }
    }
}