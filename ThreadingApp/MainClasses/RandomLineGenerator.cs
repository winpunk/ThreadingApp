using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ThreadingApp
{
    public partial class RandomLineGenerator : ILineGenerator
    {
        public string[] Generate(Random random)
        {
            string threadId;
            StringBuilder randomLineBuilder = new StringBuilder();

            try
            {
                threadId = Thread.CurrentThread.Name;

                for (int i = 0; i < random.Next(5, 10); i++)
                {
                    randomLineBuilder.Append((char)(random.Next(33, 126)));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("LineGenerator error: " + ex.Message);
                return null;
            }

            return new string[] { threadId, randomLineBuilder.ToString() };
        }
    }
}