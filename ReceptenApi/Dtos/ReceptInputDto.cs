namespace ReceptenApi.Dtos
{
    public class ReceptInputDto
    {
        public string Naam { get; set; } = string.Empty;
        public string Omschrijving { get; set; } = string.Empty;
        public int Bereidingstijd { get; set; }

    }
}
