namespace MAIA.OOP
{
    // Classe abstrata não pode ser instâciada somente herdada
    public abstract class Base
    {
        private Guid UID { get; set; }
        private DateTime Criacao { get; set; }

        public string Categoria { get; set; }

        public Base(string categoria) 
        {
            SetUID();
            SetDateTimeCriacao();
            SetCategoria(categoria);
        }

        private Guid SetUID()
        {
            return Guid.NewGuid();
        }

        private DateTime SetDateTimeCriacao()
        {
            return DateTime.Now;
        }

        private void SetCategoria(string categoria)
        {
            this.Categoria = categoria;
        }
    }
}
