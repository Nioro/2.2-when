namespace _2._2when
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.version = new System.Windows.Forms.Label();
            this.tpt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkVersion = new System.Windows.Forms.Button();
            this.timeRefreshedLabel = new System.Windows.Forms.Label();
            this.timeRefreshed = new System.Windows.Forms.Label();
            this.linkNioro = new System.Windows.Forms.Button();
            this.linkStrainxx = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(84)))), ((int)(((byte)(133)))));
            this.version.Font = new System.Drawing.Font("Microsoft YaHei", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.version.Location = new System.Drawing.Point(347, 254);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(204, 206);
            this.version.TabIndex = 0;
            this.version.Text = "...";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.version.Click += new System.EventHandler(this.label1_Click);
            // 
            // tpt
            // 
            this.tpt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpt.AutoSize = true;
            this.tpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(84)))), ((int)(((byte)(133)))));
            this.tpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.tpt.Location = new System.Drawing.Point(262, 11);
            this.tpt.Name = "tpt";
            this.tpt.Size = new System.Drawing.Size(458, 73);
            this.tpt.TabIndex = 1;
            this.tpt.Text = "2.21 released?";
            this.tpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tpt.Click += new System.EventHandler(this.tpt_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkVersion
            // 
            this.checkVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.checkVersion.FlatAppearance.BorderSize = 0;
            this.checkVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkVersion.ForeColor = System.Drawing.Color.White;
            this.checkVersion.Location = new System.Drawing.Point(749, 12);
            this.checkVersion.Name = "checkVersion";
            this.checkVersion.Size = new System.Drawing.Size(227, 72);
            this.checkVersion.TabIndex = 2;
            this.checkVersion.Text = "Refresh";
            this.checkVersion.UseVisualStyleBackColor = false;
            this.checkVersion.Click += new System.EventHandler(this.checkVersion_Click);
            // 
            // timeRefreshedLabel
            // 
            this.timeRefreshedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeRefreshedLabel.AutoSize = true;
            this.timeRefreshedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRefreshedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.timeRefreshedLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.timeRefreshedLabel.Location = new System.Drawing.Point(666, 643);
            this.timeRefreshedLabel.Name = "timeRefreshedLabel";
            this.timeRefreshedLabel.Size = new System.Drawing.Size(202, 25);
            this.timeRefreshedLabel.TabIndex = 3;
            this.timeRefreshedLabel.Text = "Last time refreshed:";
            this.timeRefreshedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeRefreshedLabel.Click += new System.EventHandler(this.timeRefreshedLabel_Click);
            // 
            // timeRefreshed
            // 
            this.timeRefreshed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeRefreshed.AutoSize = true;
            this.timeRefreshed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRefreshed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.timeRefreshed.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.timeRefreshed.Location = new System.Drawing.Point(874, 643);
            this.timeRefreshed.Name = "timeRefreshed";
            this.timeRefreshed.Size = new System.Drawing.Size(30, 25);
            this.timeRefreshed.TabIndex = 4;
            this.timeRefreshed.Text = "...";
            this.timeRefreshed.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.timeRefreshed.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // linkNioro
            // 
            this.linkNioro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.linkNioro.FlatAppearance.BorderSize = 0;
            this.linkNioro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkNioro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkNioro.ForeColor = System.Drawing.Color.White;
            this.linkNioro.Location = new System.Drawing.Point(12, 12);
            this.linkNioro.Name = "linkNioro";
            this.linkNioro.Size = new System.Drawing.Size(227, 33);
            this.linkNioro.TabIndex = 5;
            this.linkNioro.Text = "App github (Nioro)";
            this.linkNioro.UseVisualStyleBackColor = false;
            this.linkNioro.Click += new System.EventHandler(this.linkNioro_Click);
            // 
            // linkStrainxx
            // 
            this.linkStrainxx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.linkStrainxx.FlatAppearance.BorderSize = 0;
            this.linkStrainxx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkStrainxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkStrainxx.ForeColor = System.Drawing.Color.White;
            this.linkStrainxx.Location = new System.Drawing.Point(12, 51);
            this.linkStrainxx.Name = "linkStrainxx";
            this.linkStrainxx.Size = new System.Drawing.Size(227, 33);
            this.linkStrainxx.TabIndex = 6;
            this.linkStrainxx.Text = "Website github (strainxx)";
            this.linkStrainxx.UseVisualStyleBackColor = false;
            this.linkStrainxx.Click += new System.EventHandler(this.linkStrainxx_Click);
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.checkBox.Location = new System.Drawing.Point(12, 640);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(318, 28);
            this.checkBox.TabIndex = 7;
            this.checkBox.Text = "make beeps when 2.21 comes out";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(84)))), ((int)(((byte)(133)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(988, 674);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.linkStrainxx);
            this.Controls.Add(this.linkNioro);
            this.Controls.Add(this.timeRefreshed);
            this.Controls.Add(this.timeRefreshedLabel);
            this.Controls.Add(this.checkVersion);
            this.Controls.Add(this.tpt);
            this.Controls.Add(this.version);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(940, 457);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2.2 when";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label tpt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button checkVersion;
        private System.Windows.Forms.Label timeRefreshedLabel;
        private System.Windows.Forms.Label timeRefreshed;
        private System.Windows.Forms.Button linkNioro;
        private System.Windows.Forms.Button linkStrainxx;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

