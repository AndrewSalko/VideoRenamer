using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VideoRenamer
{
	class FileNameSimplifier
	{
		/// <summary>
		/// Спрощує імена файлів, прибирає укладене в дужках (), [] але збереже цифри
		/// [Salender-Raws] Princess Lover! [01] (BD 1280x720 x264 FLAC).ass буде перетворено у "Princess Lover! 01.ass"
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns>Імя файлу (без шляху), спрощеного, або null якщо не потребує спрощення чи воно не вдалося</returns>
		public string SimplifyName(string fileName)
		{
			string name = Path.GetFileName(fileName);

			string ext = Path.GetExtension(name);
			string nameWork = Path.GetFileNameWithoutExtension(name);

			Dictionary<string, object> removeStrings = new Dictionary<string, object>();

			int startInd = -1;
			int endInd = -1;
			for (int i = 0; i < nameWork.Length; i++)
			{
				char c = nameWork[i];
				if(c=='[' || c == '(')
				{
					if (startInd != -1)
						return null;

					startInd = i;
				}
				else
				{
					if(c==']' || c==')')
					{
						if (endInd != -1)
							return null;

						endInd = i;

						//додаємо як блок на видалення:
						string subText = nameWork.Substring(startInd, endInd - startInd + 1);
						removeStrings[subText] = null;

						startInd = -1;
						endInd = -1;
					}
				}
			}

			if (removeStrings.Count > 0)
			{
				foreach (var removeStr in removeStrings)
				{
					string remove = removeStr.Key;

					string replacement = string.Empty;

					//Якщо всередині строки тільки цифри, це можливо номер серії [10] таке ми прибирати не будемо а лише скобки
					string testInside = remove.Substring(1, remove.Length - 2);
					int dummy;
					if (int.TryParse(testInside, out dummy))
					{
						//прибираемо початковий та кінцевий символ
						replacement = testInside;
					}

					nameWork = nameWork.Replace(remove, replacement);
				}

				nameWork = nameWork.Trim();

				string resultName = nameWork + ext;
				return resultName;
			}

			//якщо дійшли сюди - то нічого не треба міняти
			return null;
		}

	}
}
