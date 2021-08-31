
namespace LifeSimulator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.musicON = new System.Windows.Forms.Button();
            this.musicOFF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.musicOFF);
            this.splitContainer1.Panel1.Controls.Add(this.musicON);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.numDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(977, 527);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(14, 246);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(132, 29);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(14, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 29);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numDensity
            // 
            this.numDensity.Location = new System.Drawing.Point(14, 85);
            this.numDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDensity.Name = "numDensity";
            this.numDensity.Size = new System.Drawing.Size(132, 22);
            this.numDensity.TabIndex = 4;
            this.numDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            // 
            // numResolution
            // 
            this.numResolution.Location = new System.Drawing.Point(14, 30);
            this.numResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numResolution.Name = "numResolution";
            this.numResolution.Size = new System.Drawing.Size(132, 22);
            this.numResolution.TabIndex = 1;
            this.numResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 523);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Music";
            // 
            // musicON
            // 
            this.musicON.Location = new System.Drawing.Point(14, 147);
            this.musicON.Name = "musicON";
            this.musicON.Size = new System.Drawing.Size(59, 29);
            this.musicON.TabIndex = 8;
            this.musicON.Text = "ON";
            this.musicON.UseVisualStyleBackColor = true;
            this.musicON.Click += new System.EventHandler(this.musicON_Click);
            // 
            // musicOFF
            // 
            this.musicOFF.Location = new System.Drawing.Point(89, 147);
            this.musicOFF.Name = "musicOFF";
            this.musicOFF.Size = new System.Drawing.Size(57, 29);
            this.musicOFF.TabIndex = 9;
            this.musicOFF.Text = "OFF";
            this.musicOFF.UseVisualStyleBackColor = true;
            this.musicOFF.Click += new System.EventHandler(this.musicOFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 527);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Life Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button musicOFF;
        private System.Windows.Forms.Button musicON;
        private System.Windows.Forms.Label label3;
    }
}

