namespace TestUSBBox
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SerialOpen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox_SerialPortNum = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SerialOpen
            // 
            this.btn_SerialOpen.Location = new System.Drawing.Point(8, 8);
            this.btn_SerialOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SerialOpen.Name = "btn_SerialOpen";
            this.btn_SerialOpen.Size = new System.Drawing.Size(85, 29);
            this.btn_SerialOpen.TabIndex = 82;
            this.btn_SerialOpen.Text = "打开端口";
            this.btn_SerialOpen.UseVisualStyleBackColor = true;
            this.btn_SerialOpen.Click += new System.EventHandler(this.btn_SerialOpen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(434, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 363);
            this.richTextBox1.TabIndex = 83;
            this.richTextBox1.Text = "";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(110, 16);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 12);
            this.label40.TabIndex = 85;
            this.label40.Text = "端口号";
            // 
            // comboBox_SerialPortNum
            // 
            this.comboBox_SerialPortNum.FormattingEnabled = true;
            this.comboBox_SerialPortNum.Location = new System.Drawing.Point(155, 12);
            this.comboBox_SerialPortNum.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_SerialPortNum.Name = "comboBox_SerialPortNum";
            this.comboBox_SerialPortNum.Size = new System.Drawing.Size(70, 20);
            this.comboBox_SerialPortNum.TabIndex = 84;
            this.comboBox_SerialPortNum.DropDown += new System.EventHandler(this.comboBox_SerialPortNum_DropDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(420, 285);
            this.textBox1.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "握手";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 88;
            this.button2.Text = "查询id和key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 89;
            this.button3.Text = "A模式握手";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(342, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 90;
            this.button4.Text = "清空输出窗口";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 375);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.comboBox_SerialPortNum);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_SerialOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SerialOpen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox comboBox_SerialPortNum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

