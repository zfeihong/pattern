namespace Jackyfei.Framework.PipeLine.ClientModule
{
    public interface IBuildOperationLogicPipelineObject
    {
        /// <summary>
        /// 生成一个符合当前客户端类型的处理管道
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        OperationLogicPipelineObject BuildOperationPipeline(Request request);
    }
}