using Fade_Lounge.Model;

namespace Fade_Lounge.Services;

public class KundeRepository : IKundeRepository
{
    private List<Kunde> _kundes = new List<Kunde>();

    public Kunde? UserLoggedIn { get; private set; }

    public KundeRepository(bool mockData = false)
    {
        UserLoggedIn = null;

        if (mockData)
        {
            _kundes.Add(new Kunde(1, "saed", "42546563", "hsfh@live.dk", "2000", false));
            _kundes.Add(new Kunde(1, "saaad", "98234576", "yhbh@gmail.com", "2450", true));
            _kundes.Add(new Kunde(1, "saaaad", "12456587", "peop@outlook.gb", "4312", false));
        }

    }
}