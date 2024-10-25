using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Doof.Tests.Infra;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.Extensions.DependencyInjection;

[TestFixture]
public class PlayWrightTest : PageTest
{
    protected string Url;

    private readonly CustomWebApplicationFactory _factory;

    public PlayWrightTest()
    {
        _factory = new CustomWebApplicationFactory();
        Url = _factory.ServerAddress;
    }

    [OneTimeSetUp]
    public void Setup()
    {

    }

    [OneTimeTearDown]
    public async Task TearDown()
    {
        await _factory.DisposeAsync();
    }
}

