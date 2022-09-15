namespace BuildSharper.Course301.App1.Models
{
    public class Drink
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AlcoholType AlcoholType { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
