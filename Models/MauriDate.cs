public class MauriDate
{
    private const int _giorni = 800/3;
    private const int _valoreIniziale = 800;
    private const int _valoreminimo = 500;

    public DateTime InizioBundle
    {
        get
        {
            DateTime d1;
            DateTime.TryParseExact("01-05-2024", "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out d1);
            return d1;
        }
    }

    public DateTime FineOfferta
    {
        get{return InizioBundle.AddDays(_giorni);}
    }
    public int GiorniRimanenti
    {
        get{return (int)FineOfferta.Subtract(DateTime.Now).TotalDays;}
    }

    public int ValoreDiOggi
    {
        get
        { 
            int delta = (_giorni - GiorniRimanenti) * 3; 
            int valoreOdierno = _valoreIniziale-delta;
            if (valoreOdierno < _valoreminimo )
                return _valoreminimo;
            
            return valoreOdierno;
        }
    }

}
