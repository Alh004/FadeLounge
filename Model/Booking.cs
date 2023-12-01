namespace Fade_Lounge.Model;


public class Booking

{
  
    private string _tid;        
    private string _frisør;      
    private string _herreklip;
    public bool _skæg; // true = med skæg, false=uden skæg

    private int _pris;       

    /*
     * Properties
     */                                  
    public string Tid                   
    {                                    
        get { return _tid; }            
        set { _tid = value; }           
    }                                    
                                     
    public string Frisør                    
    {                                    
        get { return _frisør; }             
        set { _frisør = value; }            
    }                                    
                                     
    public string Herreklip                  
    {                                    
        get { return _herreklip; }           
        set { _herreklip = value; }          
    }
    public bool Skæg
    {
        get { return _skæg; }
        set { _skæg = value; }
    }
    
    public int Pris            
    {                                    
        get { return _pris; }           
        set { _pris = value; }          
    }
    
    // Konstruktør
    public Booking()                                                  
    {                                                               
        _tid = "";                                           
        _frisør = "";                                                 
        _herreklip = "";
        _skæg = false; //uden skæg, default
        _pris = 0;
    }                                                               

    // Parametre Konstruktør
    public Booking(string tid, string frisør, string herreklip, bool skæg, int pris)                   
    {                                                               
        _tid = tid;                                               
        _frisør = frisør; 
        _herreklip = herreklip;
        _skæg = skæg;
        _pris = pris;
    }                                                               
}