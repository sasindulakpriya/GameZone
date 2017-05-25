namespace pcUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.testPanal = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.online = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openTask = new System.Windows.Forms.Button();
            this.closeEx = new System.Windows.Forms.Button();
            this.usbD = new System.Windows.Forms.Button();
            this.usbE = new System.Windows.Forms.Button();
            this.gameOpen1 = new System.Windows.Forms.Button();
            this.gameOpen2 = new System.Windows.Forms.Button();
            this.gameOpen3 = new System.Windows.Forms.Button();
            this.testPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "for testing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(300, 294);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(84, 31);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // testPanal
            // 
            this.testPanal.Controls.Add(this.usbE);
            this.testPanal.Controls.Add(this.usbD);
            this.testPanal.Controls.Add(this.closeEx);
            this.testPanal.Controls.Add(this.openTask);
            this.testPanal.Controls.Add(this.label2);
            this.testPanal.Controls.Add(this.label1);
            this.testPanal.Controls.Add(this.closeBtn);
            this.testPanal.Controls.Add(this.online);
            this.testPanal.Controls.Add(this.textBox);
            this.testPanal.Controls.Add(this.tBox1);
            this.testPanal.Controls.Add(this.tBox2);
            this.testPanal.Controls.Add(this.status);
            this.testPanal.Controls.Add(this.richTextBox1);
            this.testPanal.Controls.Add(this.startBtn);
            this.testPanal.Location = new System.Drawing.Point(466, 32);
            this.testPanal.Name = "testPanal";
            this.testPanal.Size = new System.Drawing.Size(413, 445);
            this.testPanal.TabIndex = 5;
            this.testPanal.Paint += new System.Windows.Forms.PaintEventHandler(this.testPanal_Paint);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(259, 136);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(135, 47);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Click to Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 20);
            this.richTextBox1.TabIndex = 1;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(58, 215);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(182, 20);
            this.status.TabIndex = 2;
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(58, 189);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(182, 20);
            this.tBox2.TabIndex = 3;
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(58, 163);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(182, 20);
            this.tBox1.TabIndex = 4;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(58, 241);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(182, 20);
            this.textBox.TabIndex = 5;
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.online.Location = new System.Drawing.Point(99, 55);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(52, 18);
            this.online.TabIndex = 6;
            this.online.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "this panal only for testing";
            // 
            // openTask
            // 
            this.openTask.Location = new System.Drawing.Point(300, 331);
            this.openTask.Name = "openTask";
            this.openTask.Size = new System.Drawing.Size(84, 35);
            this.openTask.TabIndex = 8;
            this.openTask.Text = "open taskm";
            this.openTask.UseVisualStyleBackColor = true;
            this.openTask.Click += new System.EventHandler(this.openTask_Click);
            // 
            // closeEx
            // 
            this.closeEx.Location = new System.Drawing.Point(300, 372);
            this.closeEx.Name = "closeEx";
            this.closeEx.Size = new System.Drawing.Size(84, 35);
            this.closeEx.TabIndex = 9;
            this.closeEx.Text = "close ex";
            this.closeEx.UseVisualStyleBackColor = true;
            this.closeEx.Click += new System.EventHandler(this.closeEx_Click);
            // 
            // usbD
            // 
            this.usbD.Location = new System.Drawing.Point(210, 294);
            this.usbD.Name = "usbD";
            this.usbD.Size = new System.Drawing.Size(84, 35);
            this.usbD.TabIndex = 10;
            this.usbD.Text = "USB Disable";
            this.usbD.UseVisualStyleBackColor = true;
            this.usbD.Click += new System.EventHandler(this.usbD_Click);
            // 
            // usbE
            // 
            this.usbE.Location = new System.Drawing.Point(210, 331);
            this.usbE.Name = "usbE";
            this.usbE.Size = new System.Drawing.Size(84, 35);
            this.usbE.TabIndex = 11;
            this.usbE.Text = "USB Enable";
            this.usbE.UseVisualStyleBackColor = true;
            this.usbE.Click += new System.EventHandler(this.usbE_Click);
            // 
            // gameOpen1
            // 
            this.gameOpen1.Location = new System.Drawing.Point(55, 32);
            this.gameOpen1.Name = "gameOpen1";
            this.gameOpen1.Size = new System.Drawing.Size(102, 51);
            this.gameOpen1.TabIndex = 6;
            this.gameOpen1.Text = "Game 1";
            this.gameOpen1.UseVisualStyleBackColor = true;
            this.gameOpen1.Click += new System.EventHandler(this.gameOpen1_Click);
            // 
            // gameOpen2
            // 
            this.gameOpen2.Location = new System.Drawing.Point(55, 111);
            this.gameOpen2.Name = "gameOpen2";
            this.gameOpen2.Size = new System.Drawing.Size(102, 51);
            this.gameOpen2.TabIndex = 7;
            this.gameOpen2.Text = "Game 2";
            this.gameOpen2.UseVisualStyleBackColor = true;
            // 
            // gameOpen3
            // 
            this.gameOpen3.Location = new System.Drawing.Point(55, 190);
            this.gameOpen3.Name = "gameOpen3";
            this.gameOpen3.Size = new System.Drawing.Size(102, 51);
            this.gameOpen3.TabIndex = 8;
            this.gameOpen3.Text = "Game 3";
            this.gameOpen3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(947, 543);
            this.ControlBox = false;
            this.Controls.Add(this.gameOpen3);
            this.Controls.Add(this.gameOpen2);
            this.Controls.Add(this.gameOpen1);
            this.Controls.Add(this.testPanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.fullScn);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.testPanal.ResumeLayout(false);
            this.testPanal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel testPanal;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label online;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeEx;
        private System.Windows.Forms.Button openTask;
        private System.Windows.Forms.Button usbE;
        private System.Windows.Forms.Button usbD;
        private System.Windows.Forms.Button gameOpen1;
        private System.Windows.Forms.Button gameOpen2;
        private System.Windows.Forms.Button gameOpen3;
    }
}

