public class Stampante 
{
    public string? Nome { get; set;}
    public string? Immagine { get; set;}
    public int? Ore { get; set;}
    public DateTime DataAcquisto { get; set;}
    public string strDataAcquisto => DataAcquisto.ToString("d MMMM yyyy", new System.Globalization.CultureInfo("it-IT"));
    public string? Pdf { get; set;}
}