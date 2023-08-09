using Frends.MicrosoftDynamics.CreateRecord.Definitions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace Frends.MicrosoftDynamics.CreateRecord.Tests;

[TestClass]
public class UnitTests
{
    private static readonly string _connString = Environment.GetEnvironmentVariable("HiQ_AWSS3Test_AccessKey");;
    private static readonly string _tableName = "TestTable";
    Input _input = new();
    Options _options = new();

    [TestInitialize]
    public void Init()
    {
        var param = new EntityParameter() { Name = "foo", Value = "bar" };
        _input = new()
        {
            ConnectionString = _connString,
            EntityLogicalName = "contacts",
            Parameters = new[] { param },
        };

        _options = new()
        {
            MaxRetryCount = 1,
            RetryPauseTime = 1,
            ThrowOnException = true,
        };
    }

    [TestCleanup]
    public void CleanUp()
    {
        
    }

    [TestMethod]
    public async Task TestCreateRecord_NonQuery()
    {
        
    }
}