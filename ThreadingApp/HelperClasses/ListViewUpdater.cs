using System.Collections.Concurrent;
using System.Windows.Forms;

namespace ThreadingApp
{
    public class ListViewUpdater : IListViewUpdater
    {
        private ListView _mainListView;

        public ListViewUpdater(ref ListView mainListView)
        {
            _mainListView = mainListView;
        }

        public void Update(ConcurrentQueue<string[]> generatedDatas)
        {
            if (_mainListView.InvokeRequired)
            {
                _mainListView.Invoke((MethodInvoker)delegate
                {
                    _mainListView.Items.Clear();

                    foreach (var generatedData in generatedDatas)
                    {
                        var listViewItem = new ListViewItem(generatedData);
                        _mainListView.Items.Add(listViewItem);
                    }
                });
            }
            else
            {
                foreach (var generatedData in generatedDatas)
                {
                    var listViewItem = new ListViewItem(generatedData);
                    _mainListView.Items.Add(listViewItem);
                }
            }
        }
    }
}