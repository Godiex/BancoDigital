namespace BancoDigitalApp;

public class BancoDigital
{
    private List<Persona> Personas { get; set; }

    public BancoDigital()
    {
        Personas = new List<Persona>();
    }

    public void CrearCuenta(Persona persona)
    {
        Personas.Add(persona);
    }

    public CuentaBancaria Ingresar(CredencialCuenta credencialCuenta)
    {
        var persona = Personas.FirstOrDefault(p => p.CuentaBancarias.Any(c =>
            c.CredencialCuenta.Usuario == credencialCuenta.Usuario &&
            c.CredencialCuenta.Contrasenia == credencialCuenta.Contrasenia));

        if (persona ==  null)
        {
            throw new Exception("Las credenciales solicitadas no existen");
        }
        
        var cuenta = persona?.CuentaBancarias.First(c =>
            c.CredencialCuenta.Usuario == credencialCuenta.Usuario && c.CredencialCuenta.Contrasenia == credencialCuenta.Contrasenia);
        return cuenta;
    }
}