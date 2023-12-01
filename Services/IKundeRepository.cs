using Fade_Lounge.Model;

namespace Fade_Lounge.Services

{
    public interface IKundeRepository
    {
        Kunde? KundeLoggedIn { get; }

        void AddKunde(Kunde kunde);
        bool CheckKunde(string email, string adgangskode);
        void LogoutKunde();

    }
}