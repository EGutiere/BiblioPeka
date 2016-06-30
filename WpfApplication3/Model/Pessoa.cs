using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BiblioPeka.Model
{
    [Table("Pessoas")]
    class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
