namespace ULocker
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.comboBoxRemoveableDevice = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBoxCryptoType = new System.Windows.Forms.ComboBox();
			this.buttonCryptoFile = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSelectCryptionFile = new System.Windows.Forms.Button();
			this.textBoxCryptionFilePath = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(541, 220);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage1.Controls.Add(this.groupBox7);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.buttonCryptoFile);
			this.tabPage1.Controls.Add(this.buttonClose);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(533, 194);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "加密";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.comboBoxRemoveableDevice);
			this.groupBox7.Location = new System.Drawing.Point(3, 68);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(524, 53);
			this.groupBox7.TabIndex = 5;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "选择加密用的U盘";
			// 
			// comboBoxRemoveableDevice
			// 
			this.comboBoxRemoveableDevice.FormattingEnabled = true;
			this.comboBoxRemoveableDevice.Location = new System.Drawing.Point(6, 20);
			this.comboBoxRemoveableDevice.Name = "comboBoxRemoveableDevice";
			this.comboBoxRemoveableDevice.Size = new System.Drawing.Size(508, 20);
			this.comboBoxRemoveableDevice.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Location = new System.Drawing.Point(155, 127);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(232, 59);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "密钥";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(220, 21);
			this.textBox2.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBoxCryptoType);
			this.groupBox2.Location = new System.Drawing.Point(3, 127);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(144, 59);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "加密方式";
			// 
			// comboBoxCryptoType
			// 
			this.comboBoxCryptoType.FormattingEnabled = true;
			this.comboBoxCryptoType.Items.AddRange(new object[] {
            "AES",
            "DES",
            "RSA",
            "TripleDES",
            "RC2"});
			this.comboBoxCryptoType.Location = new System.Drawing.Point(6, 24);
			this.comboBoxCryptoType.Name = "comboBoxCryptoType";
			this.comboBoxCryptoType.Size = new System.Drawing.Size(121, 20);
			this.comboBoxCryptoType.TabIndex = 0;
			// 
			// buttonCryptoFile
			// 
			this.buttonCryptoFile.Location = new System.Drawing.Point(409, 134);
			this.buttonCryptoFile.Name = "buttonCryptoFile";
			this.buttonCryptoFile.Size = new System.Drawing.Size(112, 23);
			this.buttonCryptoFile.TabIndex = 2;
			this.buttonCryptoFile.Text = "加密";
			this.buttonCryptoFile.UseVisualStyleBackColor = true;
			this.buttonCryptoFile.Click += new System.EventHandler(this.buttonCryptoFile_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new System.Drawing.Point(409, 163);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(112, 23);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "关闭";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonSelectCryptionFile);
			this.groupBox1.Controls.Add(this.textBoxCryptionFilePath);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(527, 56);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "请选择需要加密的文件";
			// 
			// buttonSelectCryptionFile
			// 
			this.buttonSelectCryptionFile.Location = new System.Drawing.Point(417, 18);
			this.buttonSelectCryptionFile.Name = "buttonSelectCryptionFile";
			this.buttonSelectCryptionFile.Size = new System.Drawing.Size(97, 23);
			this.buttonSelectCryptionFile.TabIndex = 1;
			this.buttonSelectCryptionFile.Text = "选择文件...";
			this.buttonSelectCryptionFile.UseVisualStyleBackColor = true;
			this.buttonSelectCryptionFile.Click += new System.EventHandler(this.buttonSelectCryptionFile_Click);
			// 
			// textBoxCryptionFilePath
			// 
			this.textBoxCryptionFilePath.Location = new System.Drawing.Point(6, 20);
			this.textBoxCryptionFilePath.Name = "textBoxCryptionFilePath";
			this.textBoxCryptionFilePath.Size = new System.Drawing.Size(390, 21);
			this.textBoxCryptionFilePath.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPage2.Controls.Add(this.groupBox8);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(533, 194);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "解密";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.comboBox3);
			this.groupBox8.Location = new System.Drawing.Point(3, 68);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(524, 53);
			this.groupBox8.TabIndex = 10;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "选择解密用的U盘";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(6, 20);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(508, 20);
			this.comboBox3.TabIndex = 0;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(409, 134);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "解密";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox3);
			this.groupBox4.Location = new System.Drawing.Point(155, 127);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(232, 59);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "密钥";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 24);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(220, 21);
			this.textBox3.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.comboBox2);
			this.groupBox5.Location = new System.Drawing.Point(3, 127);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(144, 59);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "解密方式";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "AES",
            "DES",
            "RSA",
            "TripleDES",
            "RC2"});
			this.comboBox2.Location = new System.Drawing.Point(6, 24);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 0;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(409, 163);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "关闭";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.button6);
			this.groupBox6.Controls.Add(this.textBox4);
			this.groupBox6.Location = new System.Drawing.Point(3, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(527, 56);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "请选择需要解密的文件";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(417, 18);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(97, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "选择文件...";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(6, 20);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(390, 21);
			this.textBox4.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 226);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "ULocker V0.4";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonSelectCryptionFile;
		private System.Windows.Forms.TextBox textBoxCryptionFilePath;
		private System.Windows.Forms.Button buttonCryptoFile;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBoxCryptoType;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.ComboBox comboBoxRemoveableDevice;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.ComboBox comboBox3;
	}
}

