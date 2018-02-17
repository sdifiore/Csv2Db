using System.ComponentModel.DataAnnotations.Schema;

namespace Csv2Db.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Representante { get; set; }
        public float PctComissao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
