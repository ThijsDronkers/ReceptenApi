namespace ReceptenApi.Entities
{
    public class Recept
    {
        public int Id { get; set; }
        public string Naam { get; set; } = string.Empty;
        public string Omschrijving { get; set; } = string.Empty;
        public int Bereidingstijd { get; set; }
        public DateTime AangemaaktOp { get; set; }

    }
}

// verplicht -> geen ?, wel = string.Empty
// optioneel -> wel ?, geen = string.Empty
// entitie is hoe het in de database staat
// dto is hoe de buitenwereld het ziet


// een migratie is een bouwtekening voor je database.
// Je hebt nu een klasse Recept in C#, maar in SQL Server bestaat nog niets: geen database, geen tabel.
// Iemand moet tegen SQL Server zeggen: “maak een tabel Recepten met de kolommen Id, Naam, Omschrijving…”.
// Dat doet een migratie.