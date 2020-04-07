using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCodeTextuel
{
	public static class De1
	{
		private static Random random = new Random();

		public static int LanceLeDe()
		{
			return random.Next(1, 7);
		}

	}

}
