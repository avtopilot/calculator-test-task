namespace Calculator.CQRS.Queries.Infrastrucute
{
    public interface IQueryProcessor
    {
        TResponse Process<TResponse, TContext>(TContext query)
            where TContext : IQueryContext<TResponse>;
    }
}