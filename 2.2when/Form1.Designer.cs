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
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(84)))), ((int)(((byte)(133)))));
            this.version.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.version.Location = new System.Drawing.Point(49, 131);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(44, 46);
            this.version.TabIndex = 0;
            this.version.Text = "...";
            this.version.Click += new System.EventHandler(this.label1_Click);
            // 
            // tpt
            // 
            this.tpt.AutoSize = true;
            this.tpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(84)))), ((int)(((byte)(133)))));
            this.tpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.tpt.Location = new System.Drawing.Point(44, 43);
            this.tpt.Name = "tpt";
            this.tpt.Size = new System.Drawing.Size(422, 73);
            this.tpt.TabIndex = 1;
            this.tpt.Text = "2.2 released?";
            this.tpt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.checkVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.checkVersion.FlatAppearance.BorderSize = 0;
            this.checkVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkVersion.ForeColor = System.Drawing.Color.White;
            this.checkVersion.Location = new System.Drawing.Point(57, 207);
            this.checkVersion.Name = "checkVersion";
            this.checkVersion.Size = new System.Drawing.Size(158, 46);
            this.checkVersion.TabIndex = 2;
            this.checkVersion.Text = "Refresh";
            this.checkVersion.UseVisualStyleBackColor = false;
            this.checkVersion.Click += new System.EventHandler(this.checkVersion_Click);
            // 
            // timeRefreshedLabel
            // 
            this.timeRefreshedLabel.AutoSize = true;
            this.timeRefreshedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRefreshedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.timeRefreshedLabel.Location = new System.Drawing.Point(129, 148);
            this.timeRefreshedLabel.Name = "timeRefreshedLabel";
            this.timeRefreshedLabel.Size = new System.Drawing.Size(202, 25);
            this.timeRefreshedLabel.TabIndex = 3;
            this.timeRefreshedLabel.Text = "Last time refreshed:";
            // 
            // timeRefreshed
            // 
            this.timeRefreshed.AutoSize = true;
            this.timeRefreshed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeRefreshed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.timeRefreshed.Location = new System.Drawing.Point(337, 148);
            this.timeRefreshed.Name = "timeRefreshed";
            this.timeRefreshed.Size = new System.Drawing.Size(30, 25);
            this.timeRefreshed.TabIndex = 4;
            this.timeRefreshed.Text = "...";
            this.timeRefreshed.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(84)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(804, 413);
            this.Controls.Add(this.timeRefreshed);
            this.Controls.Add(this.timeRefreshedLabel);
            this.Controls.Add(this.checkVersion);
            this.Controls.Add(this.tpt);
            this.Controls.Add(this.version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
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
    }
}

