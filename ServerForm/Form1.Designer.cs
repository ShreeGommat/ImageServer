namespace ServerForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HeartBeatBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CaptureIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoResolveBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeoutBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailAddBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ADBox = new System.Windows.Forms.TextBox();
            this.UpdateBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeartBeatBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureIntervalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoResolveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Path";
            // 
            // FolderPathBox
            // 
            this.FolderPathBox.Location = new System.Drawing.Point(268, 161);
            this.FolderPathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderPathBox.Name = "FolderPathBox";
            this.FolderPathBox.Size = new System.Drawing.Size(763, 26);
            this.FolderPathBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 565);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "HeartBeat";
            // 
            // HeartBeatBox
            // 
            this.HeartBeatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeartBeatBox.Location = new System.Drawing.Point(147, 555);
            this.HeartBeatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeartBeatBox.Name = "HeartBeatBox";
            this.HeartBeatBox.Size = new System.Drawing.Size(56, 30);
            this.HeartBeatBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 565);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capture Interval";
            // 
            // CaptureIntervalBox
            // 
            this.CaptureIntervalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureIntervalBox.Location = new System.Drawing.Point(489, 555);
            this.CaptureIntervalBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaptureIntervalBox.Name = "CaptureIntervalBox";
            this.CaptureIntervalBox.Size = new System.Drawing.Size(56, 30);
            this.CaptureIntervalBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 565);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Auto Resolve";
            // 
            // AutoResolveBox
            // 
            this.AutoResolveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoResolveBox.Location = new System.Drawing.Point(874, 555);
            this.AutoResolveBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoResolveBox.Name = "AutoResolveBox";
            this.AutoResolveBox.Size = new System.Drawing.Size(56, 30);
            this.AutoResolveBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 658);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Idel Timeout";
            // 
            // TimeoutBox
            // 
            this.TimeoutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeoutBox.Location = new System.Drawing.Point(147, 649);
            this.TimeoutBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeoutBox.Name = "TimeoutBox";
            this.TimeoutBox.Size = new System.Drawing.Size(56, 30);
            this.TimeoutBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Setting Server App";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Admin Email Id";
            // 
            // EmailAddBox
            // 
            this.EmailAddBox.Location = new System.Drawing.Point(268, 295);
            this.EmailAddBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailAddBox.Name = "EmailAddBox";
            this.EmailAddBox.Size = new System.Drawing.Size(763, 26);
            this.EmailAddBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1042, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 448);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "AD Group";
            // 
            // ADBox
            // 
            this.ADBox.Location = new System.Drawing.Point(268, 448);
            this.ADBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ADBox.Name = "ADBox";
            this.ADBox.Size = new System.Drawing.Size(763, 26);
            this.ADBox.TabIndex = 18;
            // 
            // UpdateBox
            // 
            this.UpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBox.Location = new System.Drawing.Point(735, 712);
            this.UpdateBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(195, 48);
            this.UpdateBox.TabIndex = 19;
            this.UpdateBox.Text = "Update ";
            this.UpdateBox.UseVisualStyleBackColor = true;
            this.UpdateBox.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 802);
            this.Controls.Add(this.UpdateBox);
            this.Controls.Add(this.ADBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailAddBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeoutBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AutoResolveBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CaptureIntervalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeartBeatBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FolderPathBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HeartBeatBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureIntervalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoResolveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderPathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HeartBeatBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CaptureIntervalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AutoResolveBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TimeoutBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmailAddBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ADBox;
        private System.Windows.Forms.Button UpdateBox;
    }
}

