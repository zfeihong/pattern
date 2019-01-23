namespace Jackyfei.Framework.PipeLine.ClientModule
{
    public class ClientForNet2Type : IBuildOperationLogicPipelineObject
    {
        /// <summary>
        /// .NET2.0的客户端类型
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
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