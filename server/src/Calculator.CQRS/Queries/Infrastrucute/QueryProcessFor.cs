namespace Calculator.CQRS.Queries.Infrastrucute
{
    public class QueryProcessFor<TResult>
    {
        private readonly IQueryProcessor _dispatcher;

        public QueryProcessFor(IQueryProcessor dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public TResult Process<TQueryContext>(TQueryContext query) where TQueryContext : IQueryContext<TResult>
        {
            return _dispatcher.Process<TResult, TQueryContext>(query);
        }
    }
}