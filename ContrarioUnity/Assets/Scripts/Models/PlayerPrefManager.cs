using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class PlayerPrefManager {
		public static int nbPlayer = 2;
		public static List<Player> playerList = new List<Player>();
		public static int nbCards = nbPlayer * 5;
	}
}
