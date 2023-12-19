using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishTest
{
	internal class QLFile
	{
		static public string doccauhoi(string duongdan)
		{
			string s = "";
			StreamReader sr = new StreamReader(duongdan);
			s=sr.ReadToEnd();
			sr.Close();
			return s;
		}
		static public List<string> docdapan(string duongdan) {
			List<string> s = new List<string>();
			StreamReader sr = new StreamReader(duongdan);
			string da = "";
			while((da = sr.ReadLine()) != null)
			{
				s.Add(da);
			}
			return s;
		}
	}

}
