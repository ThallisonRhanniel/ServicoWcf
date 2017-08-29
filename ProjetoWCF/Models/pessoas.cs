using System.Runtime.Serialization;

namespace ProjetoWCF.Models
{    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;    

    [DataContract]
    [Table("dados.pessoas")]
    public partial class pessoas
    {
        public int id { get; set; }

        [DataMember]
        public int idHash { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string valorHash { get; set; }

        [DataMember]
        [Required]
        [StringLength(30)]
        public string nome { get; set; }
    }
}
