using System;
using System.Diagnostics;

namespace ThreadingApp
{
    public class DbManager : IDbManager
    {
        public void Insert(string[] randomLineData)
        {
            try
            {
                using (var db = new GeneratedDataContext())
                {
                    var randomLine = new RandomLine()
                    {
                        ThreadId = Int32.Parse(randomLineData[0]),
                        Time = DateTime.Now,
                        Data = randomLineData[1]
                    };

                    db.RandomLines.Add(randomLine);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Database error: " + ex.Message);
            }
            
        }
    }
}