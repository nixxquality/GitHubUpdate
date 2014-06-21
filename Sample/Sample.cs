using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GitHubUpdate;

namespace Sample
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }

        void check(object sender, EventArgs e)
        {
            var check = new UpdateChecker(User.Text, Repo.Text, Version.Text);

            var button = sender as Button;
            button.Enabled = false;
            check.CheckUpdate().ContinueWith((continuation) =>
            {
                // if (continuation.Result == UpdateType.None)
                //    return;

                Invoke(new Action(() => // Go back to the UI thread
                {
                    button.Enabled = true;
                    if (continuation.Result != UpdateType.None)
                    {
                        var result = new UpdateNotifyDialog(check).ShowDialog();
                        if (result == DialogResult.Yes)
                        {
                            (check).DownloadAsset(Asset.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Up to date!");
                    }
                }));
            });
        }
    }
}
