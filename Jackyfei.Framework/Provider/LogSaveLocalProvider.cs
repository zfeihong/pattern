using System;
using System.IO;

namespace Jackyfei.Framework.Provider
{
    public class LogSaveLocalProvider:SaveLogBaseProvider
    {
        protected override bool ValidatorLogEntity(LogEntity entity)
        {
            if (base.ValidatorLogEntity(entity))
            {
                if (!string.IsNullOrEmpty(entity.Content.LogTrackInfo))
                {
                    return false;
                }
            }

            return true;
        }

        protected override void FormatLogContent(LogEntity entity)
        {
            entity.Content.Message = entity.Content.Message.Replace("//", "--");
        }


        protected override bool DoSaveLog(LogEntity entity)
        {
            //开始保存
            string path = string.Format("{0}.txt", DateTime.Now.ToString("yyyyMMdd"));
            string write = string.Format("{0} {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), entity.Content.Message);

            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                        sw.WriteLine(write);
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                        sw.WriteLine(write);
                }
            }
            catch
            {
            }

            return true;
        }
    }
}