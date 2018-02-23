using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class PlayerPrefManager {
		public static List<Player> playerList = new List<Player>();

		public static Player isWinnerPlayer(int scoreToWin) {
			foreach (Player p in playerList) {
				if (p.score == scoreToWin)
					return p;
			}
			return null;
		}

		public static void fakeFill() {
			playerList.Add(new Player("Pedro"));
			playerList.Add(new Player("Carlotta"));
			playerList.Add(new Player("Joe"));
			playerList.Add(new Player("Bobby"));
		}
	}
}
