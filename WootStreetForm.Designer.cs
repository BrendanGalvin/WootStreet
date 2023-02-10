namespace WootStreet
{
    partial class WootStreetForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.headlineTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TwitterCheckbox = new System.Windows.Forms.CheckBox();
            this.DiscordCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Market Headline Generator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop Market Headline Generator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "Generate Headline";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // headlineTimer
            // 
            this.headlineTimer.Interval = 1800000;
            this.headlineTimer.Tick += new System.EventHandler(this.headlineTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PINCODE:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Set PINCODE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(59, 141);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(660, 278);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TICKER:";
            // 
            // TwitterCheckbox
            // 
            this.TwitterCheckbox.AutoSize = true;
            this.TwitterCheckbox.Checked = true;
            this.TwitterCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TwitterCheckbox.Location = new System.Drawing.Point(143, 28);
            this.TwitterCheckbox.Name = "TwitterCheckbox";
            this.TwitterCheckbox.Size = new System.Drawing.Size(100, 17);
            this.TwitterCheckbox.TabIndex = 10;
            this.TwitterCheckbox.Text = "Post to Twitter?";
            this.TwitterCheckbox.UseVisualStyleBackColor = true;
            this.TwitterCheckbox.CheckStateChanged += new System.EventHandler(this.TwitterCheckbox_CheckStateChanged);
            // 
            // DiscordCheckbox
            // 
            this.DiscordCheckbox.AutoSize = true;
            this.DiscordCheckbox.Checked = true;
            this.DiscordCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DiscordCheckbox.Location = new System.Drawing.Point(143, 56);
            this.DiscordCheckbox.Name = "DiscordCheckbox";
            this.DiscordCheckbox.Size = new System.Drawing.Size(104, 17);
            this.DiscordCheckbox.TabIndex = 11;
            this.DiscordCheckbox.Text = "Post to Discord?";
            this.DiscordCheckbox.UseVisualStyleBackColor = true;
            this.DiscordCheckbox.CheckStateChanged += new System.EventHandler(this.DiscordCheckbox_CheckStateChanged);
            // 
            // WootStreetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DiscordCheckbox);
            this.Controls.Add(this.TwitterCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "WootStreetForm";
            this.Text = "Woot Street";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer headlineTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox TwitterCheckbox;
        private System.Windows.Forms.CheckBox DiscordCheckbox;
    }
}

