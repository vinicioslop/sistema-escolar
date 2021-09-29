namespace sistema_escolar
{
    public class Nota
    {
        private double PrimeiraNota { get; set; }
        private double SegundaNota { get; set; }
        private double TerceiraNota { get; set; }
        private double QuartaNota { get; set; }
        private double Media { get; set; }

        public double retornaPrimeiraNota()
        {
            return this.PrimeiraNota;
        }
        public double retornaSegundaNota()
        {
            return this.SegundaNota;
        }
        public double retornaTerceiraNota()
        {
            return this.PrimeiraNota;
        }
        public double retornaQuartaNota()
        {
            return this.PrimeiraNota;
        }
        public double retornaMedia()
        {
            return this.Media;
        }
    }
}