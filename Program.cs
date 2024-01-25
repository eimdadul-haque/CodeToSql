
using CodeToSql.Extensions;
using CodeToSql.IServices;
using CodeToSql.Services;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static async void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .ServiceResolve()
            .BuildServiceProvider();

        var sqlGeneratorService = serviceProvider.GetService<SqlGenerator>();
        string sqlQuery = await sqlGeneratorService.Generate();
    }
}