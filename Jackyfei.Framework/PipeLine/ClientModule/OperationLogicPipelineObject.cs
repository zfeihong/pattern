namespace Jackyfei.Framework.PipeLine.ClientModule
{
    public delegate void OperationLogicPipelineObjectModules(Request request);

    /// <summary>
    /// 处理逻辑管道对象
    /// </summary>
    public class OperationLogicPipelineObject
    {
        /// <summary>
        /// 管道中的Module引用
        /// </summary>
        private OperationLogicPipelineObjectModules modules;

        internal void Add(OperationLogicPipelineObjectModules module)
        {
            modules += module;
        }

        /// <summary>
        /// 开始管道处理
        /// </summary>
        /// <param name="request"></param>
        public void RunPipeline(Request request)
        {
            modules(request);
        }


    }
}