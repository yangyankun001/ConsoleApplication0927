using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication0927
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger logger = LogManager.GetLogger("myLog");
            //创建一个以当前类名命名的日志对象
            Logger logger = LogManager.GetCurrentClassLogger();
            //日志记录等级

            //最常见的记录信息，一般用于普通输出
            logger.Trace("Trace Message");
            //同样是记录信息，不过出现的频率要比Trace少一些，一般用来调试程序
            logger.Debug("Debug Message");
            //信息类型的消息
            logger.Info("Info Message");
            //警告信息，一般用于比较重要的场合
            logger.Warn("Warn Message");
            //错误信息
            logger.Error("Error Message");
            //致命异常信息。一般来讲，发生致命异常之后程序将无法继续执行
            logger.Fatal("Fatal Message");

            Console.ReadLine();
        }
    }
}
