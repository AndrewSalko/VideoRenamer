using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VideoRenamer.Properties;

namespace VideoRenamer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
			{
				return;
			}

			_ListBoxResult.Items.Clear();

			string startFileName = openFileDialog1.FileName;
			string dir = Path.GetDirectoryName(startFileName);

			//ищем все файлы в папке:			
			List<FileData> fileDatas=new List<FileData>();

			var files = Directory.EnumerateFiles(dir);
			if (files != null)
			{
				Dictionary<string, int> partsDict = new Dictionary<string, int>();

				FileNameSimplifier simplifier = new FileNameSimplifier();

				//просто собрали файлы (полные имена), и определяем что у них одинакового
				foreach (string itemFile in files)
				{
					string newName = simplifier.SimplifyName(itemFile);

					FileData fd = new FileData();
					fd.FileNameFull = itemFile;

					//якщо оптимізації не потребує newName==null
					fd.FileNameOptimized = newName;

					_ListBoxResult.Items.Add(fd);
				}
			}


		}

		private void _ButtonRenameFiles_Click(object sender, EventArgs e)
		{
			var askRes = MessageBox.Show(this, Resources.RenameFiles, Resources.RenameFilesTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (askRes != DialogResult.OK)
				return;

			try
			{
				for (int i = 0; i < _ListBoxResult.Items.Count; i++)
				{
					var fdata = (FileData)_ListBoxResult.Items[i];
					fdata.RenameToOptimized();
				}//for

				MessageBox.Show(this, Resources.Done, Resources.Done, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.ToString(), Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

	}
}
