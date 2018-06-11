using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class PlayerPrefManager {
		public static List<Player> playerList = new List<Player>();

		public static int selectedPack = 0;

		public static Player isWinnerPlayer(int scoreToWin) {
			foreach (Player p in playerList) {
				if (p.score == scoreToWin)
					return p;
			}
			return null;
		}

		public static Player aheadPlayer() {
			Player ahead = playerList [0];
			foreach (Player p in playerList) {
				if (p.score > ahead.score) {
					ahead = p;
				}					
			}
			return ahead;
		}
			
		public static void fakeFill() {
			playerList.Add(new Player("Joueur 1"));
			playerList.Add(new Player("Joueur 2"));
		}
	}
}
