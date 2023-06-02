namespace BancoDigitalApp;

public class CredencialCuenta
{
    public string Contrasenia { get; private set; }
    public string Usuario { get; private set; }

    public CredencialCuenta(string usuario, string contrasenia)
    {
        Usuario = usuario;
        Contrasenia = contrasenia;
    }
}