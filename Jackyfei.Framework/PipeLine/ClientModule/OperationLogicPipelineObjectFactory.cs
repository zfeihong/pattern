namespace Jackyfei.Framework.PipeLine.ClientModule
{
    public class OperationLogicPipelineObjectFactory
    {
        public static IBuildOperationLogicPipelineObject Create(RequestClientType clientType)
        {
            if (clientType.Type == RequestClientType.App)
            {
                return new ClientTypeForAppType();
            }
            else if (clientType.Type==RequestClientType.NetClient)
            {
                return new ClientForNet2Type();
            }
            return null;
        }
    }
}