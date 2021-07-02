
namespace Bloom
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.textBoxInputFile = new System.Windows.Forms.TextBox();
			this.textBoxValues = new System.Windows.Forms.TextBox();
			this.buttonGo = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownHashCount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHashCount)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonBrowse);
			this.groupBox1.Controls.Add(this.textBoxInputFile);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 56);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input File";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(400, 16);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(88, 32);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
			// 
			// textBoxInputFile
			// 
			this.textBoxInputFile.Location = new System.Drawing.Point(8, 16);
			this.textBoxInputFile.Name = "textBoxInputFile";
			this.textBoxInputFile.Size = new System.Drawing.Size(384, 23);
			this.textBoxInputFile.TabIndex = 0;
			this.textBoxInputFile.Text = "sample input.txt";
			// 
			// textBoxValues
			// 
			this.textBoxValues.Location = new System.Drawing.Point(8, 16);
			this.textBoxValues.Multiline = true;
			this.textBoxValues.Name = "textBoxValues";
			this.textBoxValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxValues.Size = new System.Drawing.Size(360, 136);
			this.textBoxValues.TabIndex = 1;
			this.textBoxValues.Text = "first\r\nsecond\r\nthird\r\nostrich";
			// 
			// buttonGo
			// 
			this.buttonGo.Location = new System.Drawing.Point(400, 184);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(104, 56);
			this.buttonGo.TabIndex = 2;
			this.buttonGo.Text = "Go";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Text files|*.txt|All files|*.*";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxValues);
			this.groupBox2.Location = new System.Drawing.Point(8, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(376, 160);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Items to Check (one per line)";
			// 
			// numericUpDownSize
			// 
			this.numericUpDownSize.Location = new System.Drawing.Point(400, 96);
			this.numericUpDownSize.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
			this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownSize.Name = "numericUpDownSize";
			this.numericUpDownSize.Size = new System.Drawing.Size(104, 23);
			this.numericUpDownSize.TabIndex = 4;
			this.numericUpDownSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(400, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Filter size (bits):";
			// 
			// numericUpDownHashCount
			// 
			this.numericUpDownHashCount.Location = new System.Drawing.Point(400, 144);
			this.numericUpDownHashCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numericUpDownHashCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownHashCount.Name = "numericUpDownHashCount";
			this.numericUpDownHashCount.Size = new System.Drawing.Size(104, 23);
			this.numericUpDownHashCount.TabIndex = 6;
			this.numericUpDownHashCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(400, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Hash count:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 249);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownHashCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDownSize);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Bloom Filter Tester v1.0";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHashCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox textBoxInputFile;
		private System.Windows.Forms.TextBox textBoxValues;
		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown numericUpDownSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownHashCount;
		private System.Windows.Forms.Label label2;
	}
}

