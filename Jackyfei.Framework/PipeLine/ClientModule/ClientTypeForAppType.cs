namespace Jackyfei.Framework.PipeLine.ClientModule
{
    /// <summary>
    /// App客户端创建者
    /// </summary>
    public class ClientTypeForAppType : IBuildOperationLogicPipelineObject
    {
        public OperationLogicPipelineObject BuildOperationPipeline(Request request)
        {
            var result = new OperationLogicPipelineObject();
            result.Add(requestObject =>
            {
                //记录App请求Log
            });
            result.Add(requestObject =>
            {
                //执行App请求
            });

            return result;
        }
    }
}