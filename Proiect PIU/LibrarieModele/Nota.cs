namespace LibrarieModele
{
    public static class Nota
    {
        public const int NOTA_MINIMA = 1;
        public const int NOTA_MAXIMA = 10;

        public static bool ValideazaNota(int nota)
        {
            if (nota >= NOTA_MINIMA && nota <= NOTA_MAXIMA)
            {
                return true;
            }

            return false;
        }
    }
}
