namespace Exercism.FloatingPointNumbers
{
    public class SpaceAgeFloat
    {
        private double seconds;
        private double years;
        public SpaceAgeFloat(int seconds)
        {
            this.seconds = Convert.ToDouble(seconds);
            years = this.seconds / 31557600;
        }
        public double OnEarth() => Math.Round(years, 2);
        public double OnMercury() => Math.Round(years * (1 / 0.2408467), 2);
        public double OnVenus() => Math.Round(years * (1 / 0.61519726), 2);
        public double OnMars() => Math.Round(years * (1 / 1.8808158), 2);
        public double OnJupiter() => Math.Round(years * (1 / 11.862615), 2);
        public double OnSaturn() => Math.Round(years * (1 / 29.447498), 2);
        public double OnUranus() => Math.Round(years * (1 / 84.016846), 2);
        public double OnNeptune() => Math.Round(years * (1 / 164.79132), 2);
    }
}
