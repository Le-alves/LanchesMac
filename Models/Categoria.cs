using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [StringLength(100,ErrorMessage = "O tamanho máximo são 100 caracteres")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [Display (Name = "nome")]
    public string CategoriaNome { get; set; }

    [StringLength(100,ErrorMessage = "O tamanho máximo são 200 caracteres")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [Display (Name = "nome")]
    public string Descricao { get; set; }
    
    public List <Lanche> Lanches { get; set;}  

}
}