namespace WcfServiceUnitConverteer
{
    public class Service1 : IService1
    {
        public double CelsiusToFahrenheit(double c) => (c * 9.0 / 5.0) + 32.0;
        public double FahrenheitToCelsius(double f) => (f - 32.0) * 5.0 / 9.0;
        public double MetersToFeet(double m) => m * 3.280839895;
        public double FeetToMeters(double ft) => ft / 3.280839895;
        public double KilogramsToPounds(double kg) => kg * 2.2046226218;
        public double PoundsToKilograms(double lb) => lb / 2.2046226218;
    }
}