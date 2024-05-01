namespace SYSTEM_GÁS.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
