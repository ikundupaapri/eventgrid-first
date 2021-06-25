using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viewer
{
    public class Logger
    {
        public void WriteLog(String Log)
        {
            string path = "D:\\Sandipan\\Pratice\\DotNet\\IoTLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(Log);

            }
        }

        internal void WriteLog(object p)
        {
            throw new NotImplementedException();
        }
    }
}
