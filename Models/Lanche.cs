using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
public class Lanche
{
    [Key]
    public int LancheId { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Nome do lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo")]

    public string Nome { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Descrição do nome")]
    [MinLength(20, ErrorMessage ="Descrição deve ter no mínimo {1} caratere")]
    [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caractere")]

    public string DescricaoCurta { get; set; }

    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Descrição do lanche")]
    [MinLength(20, ErrorMessage ="Descrição deve ter no mínimo {1} caratere")]
    [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caractere")]

    public string DescricaoDetalhada { get; set; }

    [Required(ErrorMessage = "Informe o preço do lanche")]
    [Display(Name = "Preço")]
    [Column(TypeName ="decimal (10,20")]
    [Range(1,999.99, ErrorMessage = "O número precisa ser entre 1 e 999,99 ")]

    public decimal Preco { get; set; }

    [Display(Name = "Caminho imagem normal")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo")]
    public string ImagemUrl { get; set; }

    [Display(Name = "Caminho imagem miniatura")]
    [StringLength(200, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo")]
    public string ImagemThumbnailUrl { get; set; }

    [Display(Name = "Preferido?")]
    public bool IsLanchePreferido { get; set; }
    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set;}
}
}