using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bloom
{
	public partial class MainForm : Form
	{
		public string InputFile => textBoxInputFile.Text;
		public int FilterSize => (int)numericUpDownSize.Value;
		public int HashCount => (int)numericUpDownHashCount.Value;

		public MainForm()
		{
			InitializeComponent();
		}

		private void ButtonBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;

			textBoxInputFile.Text = openFileDialog.FileName;
		}

		private void ButtonGo_Click(object sender, EventArgs e)
		{
			if (!File.Exists(InputFile))
			{
				MessageBox.Show("Please select an input file.");
				return;
			}

			var bloomFilter = new BloomFilter<string>(FilterSize, HashCount);
			bloomFilter.AddRange(File.ReadAllLines(InputFile));

			var result = new StringBuilder();
			foreach (string value in textBoxValues.Lines)
				result.AppendLine($"{value}: {bloomFilter[value]}");

			MessageBox.Show(result.ToString(), "Results");
		}
	}
}
