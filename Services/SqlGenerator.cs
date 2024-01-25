using CodeToSql.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToSql.Services;
public class SqlGenerator : ISqlGenerator
{
    public async Task<string> Generate()
    {
        return "Hello";
    }
}
