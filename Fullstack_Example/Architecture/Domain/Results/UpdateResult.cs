namespace Fullstack_Example.Architecture.Domain.Results
{
    public class UpdateResult:BehaviourResult
    {
    }

    public class UpdateResult<TResultData> : BehaviourResult<TResultData>
    {
        public UpdateResult(TResultData resultData) : base(resultData)
        {
        }
    }
}
