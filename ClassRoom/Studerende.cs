namespace ClassRoom
{
    public class Studerende
    {
        public string Navn { get; set; }
        public int Fødselsmåned { get; set; }
        public int Fødselsdag { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Fødselsmåned)}: {Fødselsmåned}, {nameof(Fødselsdag)}: {Fødselsdag}";
        }
    }
}