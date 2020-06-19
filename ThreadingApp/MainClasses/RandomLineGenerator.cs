using System;
using System.Text;
using System.Threading;

namespace ThreadingApp
{
    public partial class RandomLineGenerator : ILineGenerator
    {
        public string[] Generate(Random random)
        {
            string threadId = Thread.CurrentThread.Name;

            StringBuilder randomLineBuilder = new StringBuilder();

            for (int i = 0; i < random.Next(5, 10); i++)
            {
                randomLineBuilder.Append((char)(random.Next(33, 126)));
            }

            return new string[] { threadId, randomLineBuilder.ToString() };
        }
    }
}