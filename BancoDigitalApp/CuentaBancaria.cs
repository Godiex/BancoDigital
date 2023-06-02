namespace BancoDigitalApp;

public class CuentaBancaria
{
    public string NumeroCuenta { get; private set; }
    public decimal Saldo { get; private set; }
    public string CedulaPersona { get; set; }
    public CredencialCuenta CredencialCuenta { get; set; }

    public CuentaBancaria(string cedulaPersona, string usuario, string contrasenia)
    {
        Saldo = 0;
        CredencialCuenta = new CredencialCuenta(usuario, contrasenia);
    }

    public void Consignar(decimal valorAConsignar)
    {
        _ = valorAConsignar < 0 ? throw new Exception("no se puede digitar valores a consignar negativos") : 0;
        Saldo += valorAConsignar;
    }
    
    public void Retirar(decimal valorARetirar)
    {
        _ = valorARetirar < 0 ? throw new Exception("no se puede digitar valores a retirar negativos") : 0;
        Saldo -= valorARetirar;
    }
}