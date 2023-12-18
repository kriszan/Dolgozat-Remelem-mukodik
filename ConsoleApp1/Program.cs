using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			while (true)
			{
				Console.WriteLine("Kérem adjon meg egy számot (0-val vége a programnak)");
				try
				{
					int tmp = int.Parse(Console.ReadLine().Trim());
					/*if (tmp == 0)
					{
						Console.WriteLine("A minimum érték: " + list.Min());
						Console.WriteLine("A maximum érték: " + list.Max());
						return;
					}*/
					list.Add(tmp);
					Console.WriteLine("Eddig megadott számok: " + string.Join(", ", list));
				}
				catch
				{
					Console.WriteLine("Nem számot adott meg");
				}
			}
		}
	}
}
