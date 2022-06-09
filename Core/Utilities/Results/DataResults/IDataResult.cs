namespace Core.Utilities.Results.DataResults
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
