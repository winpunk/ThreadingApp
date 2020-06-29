using System;
using System.Windows.Forms;

namespace ThreadingApp
{
    public partial class ThreadingApp : Form
    {
        private ThreadsManager _threadManager;

        public ThreadingApp(IDbManager dbManager, ILineGenerator lineGenerator)
        {
            InitializeComponent();
            _threadManager = new ThreadsManager(dbManager, new ListViewUpdater(ref mainListView), lineGenerator);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            mainListView.Items.Clear();

            if (!Int32.TryParse(threadTextBox.Text, out int threadCount) || threadCount < 2 || threadCount > 15)
            {
                MessageBox.Show("You entered the incorrect thread number value. Please enter number from 2 to 15.");

                startButton.Enabled = true;
                stopButton.Enabled = false;

                return;
            }

            _threadManager.StartThreads(threadCount);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _threadManager.StopThreads();

            startButton.Enabled = true;
            stopButton.Enabled = false;
        }
    }
}