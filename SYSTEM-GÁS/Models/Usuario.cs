namespace SYSTEM_GÁS.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string endereco { get; set;}
        public int telefone { get; set; }

        public int CategoriaId { get; set; }    
        public virtual Categoria Categoria { get; set;}
    }
}
