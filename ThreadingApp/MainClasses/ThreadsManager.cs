using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingApp
{
    public class ThreadsManager
    {
        private Task[] _threads;
        private CancellationTokenSource _stopThreadingTokenSource;

        private ConcurrentQueue<string[]> _generatedDatas;

        private IListViewUpdater _listUpdater;
        private IDbManager _dbManager;
        private ILineGenerator _lineGenerator;

        public ThreadsManager(IDbManager dbManager, IListViewUpdater listViewUpdater, ILineGenerator lineGenerator)
        {
            _listUpdater = listViewUpdater;
            _dbManager = dbManager;
            _lineGenerator = lineGenerator;
        }

        public void StartThreads(int threadCount)
        {
            _stopThreadingTokenSource = new CancellationTokenSource();
            _threads = new Task[threadCount];
            _generatedDatas = new ConcurrentQueue<string[]>();

            var random = new Random();

            try
            {
                for (int i = 0; i < threadCount; i++)
                {
                    CancellationToken ct = _stopThreadingTokenSource.Token;

                    string iCopy = (i + 1).ToString();

                    _threads[i] = Task.Factory.StartNew(() =>
                    {
                        Thread.CurrentThread.Name = iCopy;

                        GeneratorThread(random, ct);
                    }, ct);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        public void StopThreads()
        {
            _stopThreadingTokenSource.Cancel();
        }

        public void GeneratorThread(Random random, CancellationToken ct)
        {
            int interval = random.Next(500, 2000);

            try
            {
                while (!ct.IsCancellationRequested)
                {
                    if (_generatedDatas.Count > 20) _generatedDatas.TryDequeue(out _);

                    var lineData = _lineGenerator.Generate(random);

                    _generatedDatas.Enqueue(lineData);

                    _listUpdater.Update(_generatedDatas);

                    _dbManager.Insert(lineData);

                    Thread.Sleep(interval);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }
    }
}