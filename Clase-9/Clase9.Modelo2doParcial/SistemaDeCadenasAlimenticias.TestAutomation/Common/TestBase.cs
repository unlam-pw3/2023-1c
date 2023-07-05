using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaDeCadenasAlimenticias.Data.EF;

namespace SistemaDeCadenasAlimenticias.TestAutomation.Common;

public class TestBase
{
    private ServiceCollection Services { get; set; }
    protected ServiceProvider ServiceProvider { get; private set; }

    protected TestBase()
    {
        // Arrange
        Services = new ServiceCollection();
        Services.AddDbContext<Pw320231cModelo2doParcialContext>();


        //Services.AddDbContext<Pw320231cModelo2doParcialContext>(options =>
        //    options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()));

        ServiceProvider = Services.BuildServiceProvider();
    }
}
