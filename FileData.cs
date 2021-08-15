using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VideoRenamer
{
	class FileData
	{
		public string FileNameFull
		{
			get;
			set;
		}

		/// <summary>
		/// Оптимізоване ім'я файлу (без шляху)
		/// </summary>
		public string FileNameOptimized
		{
			get;
			set;
		}

		public override string ToString()
		{
			string result;

			if (FileNameOptimized != null)
			{
				result = FileNameOptimized;
			}
			else
			{
				result = Path.GetFileName(FileNameFull);
			}

			return result;
		}

		public void RenameToOptimized()
		{
			if (FileNameOptimized == null)
				return;

			string dir = Path.GetDirectoryName(FileNameFull);

			string newFileName = Path.Combine(dir, FileNameOptimized);

			File.Move(FileNameFull, newFileName);
		}

	}
}
