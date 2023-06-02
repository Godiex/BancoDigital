namespace BancoDigitalApp;

public class Persona
{
    public string Nombre { get; set; }
    public string Cedula { get; set; }
    public List<CuentaBancaria> CuentaBancarias { get; set; }

    public Persona(string nombre, string cedula, CuentaBancaria cuentaBancaria)
    {
        Nombre = nombre;
        Cedula = cedula;
        CuentaBancarias = new List<CuentaBancaria> { cuentaBancaria };
    }
}