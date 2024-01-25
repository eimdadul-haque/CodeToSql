
using CodeToSql.Extensions;
using CodeToSql.IServices;
using CodeToSql.Services;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .ServiceResolve()
            .ConsumerResolve()
            .BuildServiceProvider();

        string sql = string.Empty;
        Task.Run(async () => { sql = await sqlGeneratorService.Generate(); }); 
    }
}