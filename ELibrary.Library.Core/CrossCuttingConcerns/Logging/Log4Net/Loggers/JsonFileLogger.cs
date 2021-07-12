using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class JsonFileLogger : LoggerService
    {
        public JsonFileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {

        }
    }
}
