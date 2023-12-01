namespace Fade_Lounge.Model;

public class Admin
{
  
    private string _navn;       
    private string _tlf;        
    private string _email;      
    private string _adgangskode;
    
    /*
     * Properties
     */                                  
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
    
    public string Adgandskode                  
    {                                    
        get { return _adgangskode; }           
        set { _adgangskode = value; }          
    }                
    
    public Admin()                                                  
    {                                                               
        _navn = "";                                           
        _tlf = "";                                                 
        _email = "";
        _adgangskode = "";
    }                                                               
    public Admin (string navn, string tlf, string email, string adgangskode)                   
    {                                                               
        _navn = navn;                                               
        _tlf = tlf;
        _email = email;
        _adgangskode = adgangskode;

    }                                                               
}