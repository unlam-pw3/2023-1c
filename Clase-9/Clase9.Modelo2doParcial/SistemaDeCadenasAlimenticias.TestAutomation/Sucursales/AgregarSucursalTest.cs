using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SistemaDeCadenasAlimenticias.Data.EF;
using SistemaDeCadenasAlimenticias.TestAutomation.Common;
using Xunit;

namespace SistemaDeCadenasAlimenticias.TestAutomation.Sucursales;


public class AgregarSucursalTest : TestBase
{
    private IWebDriver driver;
    private const string BaseUrl = "https://localhost:7042";
    private const string AgregarSucursalUrl = $"{BaseUrl}/sucursales/agregar";
    private const string ListarSucursalesUrl = $"{BaseUrl}/sucursales/listar";

    private const string _prefijoCiudadSucursalesAgregadas = "sucursal_test";

    public AgregarSucursalTest()
    {
        // Configura el driver de Selenium (en este caso, se utiliza ChromeDriver)
        driver = new ChromeDriver();
    }

    [Fact]
    public void AgregarSucursal_Test()
    {
        // Arrange


        // Act

        // Navega a la página de agregar sucursales
        driver.Navigate().GoToUrl(AgregarSucursalUrl);

        // Completa el formulario con los datos necesarios
        SelectElement cadenaDropdown = new SelectElement(driver.FindElement(By.Name("IdCadena")));
        cadenaDropdown.SelectByText("Makro"); // Reemplaza por el valor adecuado

        IWebElement direccionInput = driver.FindElement(By.Name("Direccion"));
        direccionInput.SendKeys("test aaaa"); // Reemplaza por el valor adecuado

        IWebElement ciudadInput = driver.FindElement(By.Name("Ciudad"));
        ciudadInput.SendKeys($"{_prefijoCiudadSucursalesAgregadas} Ramos Mejia"); // Reemplaza por el valor adecuado

        // Envía el formulario
        driver.FindElement(By.CssSelector("input[type='submit']")).Click();

        // Espera hasta que se redirija a la página de listar sucursales (puede requerir una espera explícita)
        // Aquí puedes utilizar técnicas de espera explícita para esperar que la redirección ocurra correctamente

        //Assert
        // Verifica si el registro se ha agregado correctamente en la página de listar sucursales

        Assert.Equal(driver.Url, ListarSucursalesUrl, true);
        Assert.True(driver.PageSource.Contains("test aaaa"));

    }

    public void CleanUp()
    {
        // Cierra el navegador y finaliza la prueba
        var context = ServiceProvider.GetService<Pw320231cModelo2doParcialContext>()!;

        foreach (var sucursal in context.Sucursals.Where(s => s.Ciudad.StartsWith(_prefijoCiudadSucursalesAgregadas)))
        {
            context.Sucursals.Remove(sucursal);
        }

        context.SaveChanges();

        driver.Quit();
    }
}