namespace projetocrud
{
    public class Cliente : Entidade
    {
        public string? NomeCompleto { get; set; }

        public string? CPF { get; set; }

        public string? DataDeNascimento { get; set; }

        public double RendaMensal {get; set;}

        public string? Endereco { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }

        public bool Excluido { get; set; }

        
       public string RetornarNomeCompleto()
       {
           return this.NomeCompleto!;
       }

        public int RetornarId()
        {
            return this.id;
        }

    
    }
}