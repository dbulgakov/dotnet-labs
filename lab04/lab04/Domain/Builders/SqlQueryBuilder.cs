using System.Text;

namespace lab04.Domain.Builders;

public sealed class SqlQueryBuilder
{
    private readonly StringBuilder _query = new();

    public SqlQueryBuilder Select(params string[] fields)
    {
        _query.Append("SELECT ").Append(string.Join(", ", fields)).Append(" ");
        return this;
    }

    public SqlQueryBuilder From(string table)
    {
        _query.Append("FROM ").Append(table).Append(" ");
        return this;
    }

    public SqlQueryBuilder Where(string condition)
    {
        _query.Append("WHERE ").Append(condition).Append(" ");
        return this;
    }

    public SqlQueryBuilder OrderBy(string field)
    {
        _query.Append("ORDER BY ").Append(field);
        return this;
    }

    public string Build() => _query.ToString().Trim();
}