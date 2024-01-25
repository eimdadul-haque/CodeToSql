using CodeToSql.IConsumer;
using CodeToSql.IServices;

namespace CodeToSql.Consumer;
public class SqlQueryProvider : ISqlQueryProvider
{
    private readonly ISqlGenerator _sqlGenerator;
    public SqlQueryProvider(
        ISqlGenerator sqlGenerator)
    {
        _sqlGenerator = sqlGenerator;
    }
}
