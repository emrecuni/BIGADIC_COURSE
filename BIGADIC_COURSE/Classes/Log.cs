using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIGADIC_COURSE.Classes
{
    public static class Log
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static int DeleteOldLogs()
        {
            try
            {
                string logPath = Application.StartupPath + "\\logs";
                var allLogs = Directory.GetFiles(logPath);

                return 1;
            }
            catch (Exception ex)
            {
                logger.Error($"Eski Loglar Silinirken Bir Hata Oluştu. ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                return -1;
            }
        }
    }
}
