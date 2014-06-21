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
            this.Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Repo = new System.Windows.Forms.TextBox();
            this.Version = new System.Windows.Forms.TextBox();
            this.Asset = new System.Windows.Forms.TextBox();
            this.ProductVersion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // check
            // 
            this.Check.Location = new System.Drawing.Point(251, 81);
            this.Check.Name = "check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 0;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.check);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pretend that we\'re this version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asset";
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
            // ProductVersion
            // 
            this.ProductVersion.AutoSize = true;
            this.ProductVersion.Location = new System.Drawing.Point(159, 59);
            this.ProductVersion.Name = "ProductVersion";
            this.ProductVersion.Size = new System.Drawing.Size(175, 17);
            this.ProductVersion.TabIndex = 11;
            this.ProductVersion.Text = "Use Application.ProductVersion";
            this.ProductVersion.UseVisualStyleBackColor = true;
            this.ProductVersion.CheckedChanged += new System.EventHandler(this.ProductVersion_CheckedChanged);
            // 
            // Sample
            // 
            this.AcceptButton = this.Check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 107);
            this.Controls.Add(this.ProductVersion);
            this.Controls.Add(this.Asset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Repo);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check);
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
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private new System.Windows.Forms.CheckBox ProductVersion;
    }
}

