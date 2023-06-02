using BancoDigitalApp;

namespace TestConsola;

[TestClass]
public class TestCuentaBancaria
{
    private CuentaBancaria _cuentaBancaria;

    public TestCuentaBancaria()
    {
        _cuentaBancaria = new CuentaBancaria("12313", "anderson", "123");
    }
    
    [TestMethod]
    public void ConsignarEnCuentaBancariaCuandoEsUnValorValido()
    {
        _cuentaBancaria.Consignar(20000);
        Assert.AreEqual(_cuentaBancaria.Saldo, 20000);
    }
    
    [TestMethod]
    public void ConsignarEnCuentaBancariaCuandoEsUnValorNoValido()
    {
        try
        {
            _cuentaBancaria.Consignar(-20000);
        }
        catch (Exception e)
        {
            Assert.AreEqual(e.Message, "no se puede digitar valores a consignar negativos");
        }
    }
}