namespace ReceptenApi.Dtos
{
    public class ReceptDto
    {
        public int Id { get; set; }
        public string Naam { get; set; } = string.Empty;
        public string Omschrijving { get; set; } = string.Empty;
        public int Bereidingstijd { get; set; }
        public DateTime AangemaaktOp { get; set; }
    }
}
