namespace Fullstack_Example.Architecture.Domain.Results
{
    public class DeleteResult:BehaviourResult
    {
    }

    public class DeleteResult<TResultData> : BehaviourResult<TResultData>
    {
        public DeleteResult(TResultData resultData) : base(resultData)
        {
        }
    }
}
