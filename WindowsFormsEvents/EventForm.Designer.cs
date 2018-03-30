namespace WindowsFormsEvents
{
    partial class EventForm
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
            this.components = new System.ComponentModel.Container();
            this.Firstbutton = new System.Windows.Forms.Button();
            this.Secondbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarLong = new System.Windows.Forms.ProgressBar();
            this.progressBarShort = new System.Windows.Forms.ProgressBar();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Firstbutton
            // 
            this.Firstbutton.Location = new System.Drawing.Point(12, 12);
            this.Firstbutton.Name = "Firstbutton";
            this.Firstbutton.Size = new System.Drawing.Size(101, 23);
            this.Firstbutton.TabIndex = 0;
            this.Firstbutton.Text = "First button";
            this.Firstbutton.UseVisualStyleBackColor = true;
            this.Firstbutton.Click += new System.EventHandler(this.button_Click);
            // 
            // Secondbutton
            // 
            this.Secondbutton.Location = new System.Drawing.Point(13, 42);
            this.Secondbutton.Name = "Secondbutton";
            this.Secondbutton.Size = new System.Drawing.Size(100, 23);
            this.Secondbutton.TabIndex = 1;
            this.Secondbutton.Text = "Second button";
            this.Secondbutton.UseVisualStyleBackColor = true;
            this.Secondbutton.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBarLong);
            this.panel1.Controls.Add(this.progressBarShort);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Location = new System.Drawing.Point(13, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 75);
            this.panel1.TabIndex = 2;
            // 
            // progressBarLong
            // 
            this.progressBarLong.Location = new System.Drawing.Point(4, 34);
            this.progressBarLong.Name = "progressBarLong";
            this.progressBarLong.Size = new System.Drawing.Size(366, 23);
            this.progressBarLong.TabIndex = 3;
            // 
            // progressBarShort
            // 
            this.progressBarShort.Location = new System.Drawing.Point(168, 4);
            this.progressBarShort.Name = "progressBarShort";
            this.progressBarShort.Size = new System.Drawing.Size(202, 23);
            this.progressBarShort.TabIndex = 2;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(86, 4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 215);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Secondbutton);
            this.Controls.Add(this.Firstbutton);
            this.Name = "EventForm";
            this.Text = "Events Timer & Click button";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Firstbutton;
        private System.Windows.Forms.Button Secondbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBarLong;
        private System.Windows.Forms.ProgressBar progressBarShort;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer;
    }
}

