namespace Calculator.CQRS.Queries.Infrastrucute
{
    public interface IQuery<in TQueryContext, out TResponse>
        where TQueryContext : IQueryContext<TResponse>
    {
        TResponse Execute(TQueryContext queryContext);
    }
}