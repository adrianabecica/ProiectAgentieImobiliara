using NivelAccesDate;
using System.Configuration;

namespace Agentie_Imobiliara
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        private const string FORMAT_SALVARE_B = "FormatSalvare_b";
        private const string NUME_FISIER_B = "NumeFisier_b";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareImobiliare_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareImobiliare_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }

        public static IStocareData_Beneficiar GetAdministratorStocareBeneficiar()
        {
            var formatSalvare_b = ConfigurationManager.AppSettings[FORMAT_SALVARE_B];
            var numeFisier_b = ConfigurationManager.AppSettings[NUME_FISIER_B];
            if (formatSalvare_b != null)
            {
                switch (formatSalvare_b)
                {
                    default:
                    case "bin":
                        return new AdministrareBeneficiari_FisierBinar(numeFisier_b + "." + formatSalvare_b);
                    case "txt":
                        return new AdministrareBeneficiari_FisierText(numeFisier_b + "." + formatSalvare_b);
                }
            }

            return null;
        }
    }
}
