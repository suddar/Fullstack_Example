namespace Fullstack_Example.Architecture.Domain.Results
{
    public class GetResult:BehaviourResult
    {
    }

    public class GetResult<TResultData> : BehaviourResult<TResultData>
    {
        public GetResult(TResultData resultData) : base(resultData)
        {
        }
    }
}
