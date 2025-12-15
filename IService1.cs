using System.ServiceModel;

namespace WcfServiceUnitConverteer
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract] double CelsiusToFahrenheit(double celsius);
        [OperationContract] double FahrenheitToCelsius(double fahrenheit);
        [OperationContract] double MetersToFeet(double meters);
        [OperationContract] double FeetToMeters(double feet);
        [OperationContract] double KilogramsToPounds(double kilograms);
        [OperationContract] double PoundsToKilograms(double pounds);
    }
}