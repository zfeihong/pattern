namespace Jackyfei.Framework.PipeLine.ClientModule
{
    public delegate void ClientPipelineObjectModules(Request request);

    public class ClientPipelineObject
    {
        private ClientPipelineObjectModules modules;

        /// <summary>
        /// 添加管道模块
        /// </summary>
        /// <param name="module"></param>
        public void AddModule(ClientPipelineObjectModules module)
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