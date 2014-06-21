namespace Sample
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button check;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            this.User = new System.Windows.Forms.TextBox();
            this.Repo = new System.Windows.Forms.TextBox();
            this.Version = new System.Windows.Forms.TextBox();
            this.Asset = new System.Windows.Forms.TextBox();
            check = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check
            // 
            check.Location = new System.Drawing.Point(207, 72);
            check.Name = "check";
            check.Size = new System.Drawing.Size(75, 23);
            check.TabIndex = 0;
            check.Text = "Check";
            check.UseVisualStyleBackColor = true;
            check.Click += new System.EventHandler(this.check);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 13);
            label2.TabIndex = 2;
            label2.Text = "Repo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(177, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(149, 13);
            label4.TabIndex = 5;
            label4.Text = "Pretend that we\'re this version";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(53, 6);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(100, 20);
            this.User.TabIndex = 3;
            this.User.Text = "nixxquality";
            // 
            // Repo
            // 
            this.Repo.Location = new System.Drawing.Point(53, 33);
            this.Repo.Name = "Repo";
            this.Repo.Size = new System.Drawing.Size(100, 20);
            this.Repo.TabIndex = 4;
            this.Repo.Text = "WebMConverter";
            // 
            // Version
            // 
            this.Version.Location = new System.Drawing.Point(180, 33);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(138, 20);
            this.Version.TabIndex = 8;
            this.Version.Text = "1.0";
            // 
            // Asset
            // 
            this.Asset.Location = new System.Drawing.Point(53, 59);
            this.Asset.Name = "Asset";
            this.Asset.Size = new System.Drawing.Size(100, 20);
            this.Asset.TabIndex = 10;
            this.Asset.Text = "Converter.zip";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 13);
            label3.TabIndex = 9;
            label3.Text = "Asset";
            // 
            // Sample
            // 
            this.AcceptButton = check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 107);
            this.Controls.Add(this.Asset);
            this.Controls.Add(label3);
            this.Controls.Add(this.Version);
            this.Controls.Add(label4);
            this.Controls.Add(this.Repo);
            this.Controls.Add(this.User);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(check);
            this.Name = "Sample";
            this.Text = "Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Repo;
        private System.Windows.Forms.TextBox Version;
        private System.Windows.Forms.TextBox Asset;
    }
}

