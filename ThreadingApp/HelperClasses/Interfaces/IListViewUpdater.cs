using System.Collections.Concurrent;

namespace ThreadingApp
{
    public interface IListViewUpdater
    {
        void Update(ConcurrentQueue<string[]> generatedDatas);
    }
}