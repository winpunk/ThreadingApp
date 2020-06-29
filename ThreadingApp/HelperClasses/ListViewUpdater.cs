using System;
using System.Collections.Concurrent;
using System.Diagnostics;
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
            try
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
            catch (Exception ex)
            {
                Debug.WriteLine("ListView update error: " + ex.Message);
            }
        }
    }
}