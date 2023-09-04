namespace Digital_Circle.Back.Domain.Entidades
{
    public class Entidade
    {
        public Guid Id { get; set; }

        public string Texto { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;
    }
}
