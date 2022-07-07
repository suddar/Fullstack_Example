namespace Fullstack_Example.Architecture.Domain.Results
{
    public class CreateResult:BehaviourResult
    {
    }

    public class CreateResult<TResultData> : BehaviourResult<TResultData>
    {
        public CreateResult(TResultData resultData) : base(resultData)
        {
        }
    }
}
