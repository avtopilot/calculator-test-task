namespace Calculator.CQRS.Queries.Infrastrucute
{
    public static class QueryProcessExtension
    {
        public static QueryProcessFor<TResult> For<TResult>(this IQueryProcessor queryDispatcher)
        {
            return new QueryProcessFor<TResult>(queryDispatcher);
        }
    }
}