namespace Fullstack_Example.Architecture.Domain.Results
{
    public abstract class BehaviourResult : BehaviourResultBase
    {
    }

    public abstract class BehaviourResult<TResultData> : BehaviourResultBase
    {
        public TResultData? Data { get; set; }

        public BehaviourResult(TResultData resultData)
        {
            Data = resultData;
        }
    }

    public abstract class BehaviourResultBase
    {
        public string? Message { get; set; }
        public BehaviorStatus StatusCode { get; set; }
    }
}
