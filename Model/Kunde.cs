namespace Fade_Lounge.Model;

public class Kunde
{
    /*
     * Instans felter
     */
    private int _kundeNummer;
    private string _navn;
    private string _tlf;
    private string _email;
    private string _adgangskode;
    private bool _isAdmin;


    /*
     * Properties
     */
    public int KundeNummer
    {
        get { return _kundeNummer; }
        set { _kundeNummer = value; }
    }

    public string Navn
    {
        get { return _navn; }
        set { _navn = value; }
    }

    public string Tlf
    {
        get { return _tlf; }
        set { _tlf = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Adgangskode                   
    {                                           
        get { return _adgangskode; }            
        set { _adgangskode = value; }           
    }
    public bool isadmin                
    {                                  
        get { return _isAdmin; }       
        set { _isAdmin = value; }      
    }                                  
    
    public Kunde()
    {
        _kundeNummer = 0;
        _navn = "";
        _tlf = "";
        _email = "";
        _adgangskode = "";
        _isAdmin = false;

    }

    public Kunde(int kundeNummer, string navn, string tlf, string email, string adgangskode, bool isAdmin)
    {
        _kundeNummer = kundeNummer;
        _navn = navn;
        _tlf = tlf;
        _email = email;
        _adgangskode = adgangskode;
        _isAdmin = isAdmin;
    }

    public override string ToString()
    {
        return $"KundeNummer: {_kundeNummer}, Navn: {_navn}, Tlf: {_tlf}, Email: {_email}, Adgangskode: {_adgangskode}, IsAdmin: {_isAdmin}";
    }


}
