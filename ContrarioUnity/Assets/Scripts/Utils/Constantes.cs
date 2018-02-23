using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constantes
{
	// SCENE
	public const string SCENE_WELCOME = "MainScene";
	public const string SCENE_PLAYER_SETTINGS = "PlayerSettingsScene";
	public const string SCENE_GAME = "GameScene";


	public static readonly string[] WORDS_AND_DEFS = {
		"Les crocs du lac---Les dents de la mer---Cinéma---Streven Spielberg",
		"Un atlas noir---Une carte grise---Administratif---Automobile",
		"Nous les filles---Vous les femmes---Chanson---Julio Iglesias",
		"Quai-au-Roi---Port-au-Prince---Géographie---Haïti",
		"Bijoutier dans la substance---Orfèvre en la matière---Expression---Connaître parfaitement quelque chose",
		"Se balancer hors de la tronche de l'agneau---Se jeter dans la geule du loup---Expression---Se précipiter vers le danger",
		"Le petit muret d'algues---La grande barrière de corail---Géographie---Australie",
		"Lièvre ignare---Tortue géniale---Dessin animé---Dragon Ball",
		"Le gala du Monde---La fête de l'Humanité---Politique---Parti Communiste",
		"Louveteau Jamais---Scout toujours---Cinéma---Gérard Jugnot",
		"La haine devient bébé du Tyrol---L'amour est enfant de Bohème---Musique---Carmen",
		"Celles qui me détestent attraperont un taxi---Ceux qui m'aiment prendront le train---Cinéma---Patrice Chéreau",
		"Plan Blanc---Carte Noire---Marque---Try to remember",
		"Un Joseph allonge-moi ici---Une Marie couche-toi là---Surnom---Fille facile",
		"La Colossale Librairie---La Grande Bibliothèque---Monument---Fraçois Mitterrand",
		"Les six enfoirés---Les douze salopards---Cinéma---Film de guerre",
		"30 milliards d'abstinents---60 millions de consommateurs---Presse---Comparatif d'achats",
		"Les chaînes de division---Les tables de multiplication---Éducation---Arithmétique",
		"Avenue de la Guerre---Rue de la paix---Lieu---Très côtée au Monopoly",
		"Tripoter le petit paquet---Toucher le gros lot---Expression---Jackpot",
		"Une élite chavirée---Une crème renversée---Cuisine---Dessert",
		"Ton fils ce couard---Mon père ce héros---Cinéma---Gérard Depardieu",
		"Les ossements de la vie---Les reliques de la mort---Littérature---Harry Potter",
		"Le dimanche sous la pluie---Le lundi au soleil---Chanson---Claude François",
		"Une patte-de-cerf---Un pied-de-biche---Objet---Cambrioleur",
		"La nuit la plus courte---Le jour le plus long---Cinéma---Normandie",
		"Le bond au caoutchouc---Le saut à l'élastique---Sport---Pour les non-cardiaques",
		"Le rond-point du Jura---La place des Vosges---Lieu---Paris",
		"Seconde cocon !---Minute papillon !---Expression---Pas si vite",
		"Un homme au feu---Une femme au foyer---Activité professionnelle---Se fait à domicile",
		"Un bras de fer---Une jambe de bois---Objet---Prothèse",
		"\"Dure journée, sacrée journée\"---\"Douce nuit, sainte nuit\"---Chanson---Noël",
		"Une compagnie à culpabilité étendue---Une société à responsabilité limitée---Juridique---SARL",
		"Marche sans les agneaux---Danse avec les loups---Cinéma---Kevin Costner",
		"\"Pêchez l'artificiel, il arrive au trot\"---\"Chassez le naturel, il revient au galop\"---Proverbe---Penchant",
		"Les ruptures tranquilles---Les liaisons dangereuses---Cinéma---John Malkovitch",
		"Le Débit Viticole---Le Crédit Agricole---Organisme---Banque",
		"Se trouver coupé tel les maïs---Être fauché comme les blés---Expression---Sans argent",
		"Un lézard à clochette---Un serpent à sonnette---Reptile---Crotale",
		"Expédié ordinaire---Envoyé spécial---Télévision---Magazine d'information",
		"Une ronde de truie---Un tour de cochon---Expression---Vilain coup",
		"Périple à la surface du monde---Voyage au centre de la terre---Littérature---Jules Verne",
		"Réapparition sur le passé---Retour vers le futur---Cinéma---Voyage dans le temps",
		"Un jardin à moules---Un parc à huîtres---Lieu---Bord de mer",
		"Ton tourniquet à toi---Mon manège à moi---Chanson---Edith Piaf",
		"Lubrifier le pied---Graisser la patte---Expression---Pot de vin",
		"\"Le mois suivant, tu enfiles le haut\"---\"La semaine prochaine, j'enlève le bas\"---Slogan---Affichage",
		"La saison des fraises---Le temps des cerises---Chanson---Jean-Baptiste Clément",
		"La Traversée de la Gaule---Le Tour de France---Cyclisme---Maillot jaune",
		"Relâche-toi quand je veux---Arrête-moi si tu peux---Cinéma---Steven Spielberg",
		"Le Théâtre République---L'Opéra Bastille---Monument---Construit sous Mitterand",
		"Papa les grands navires---Maman les petits bateaux---Chanson---Pour les enfants",
		"Un déjeuner quasi raté---Un dîner presque parfait---Télévision---M6",
		"Acheter la boucle---Vendre la mèche---Expression---Dévoiler un secret",
		"La plaine Épluchée---La montage Pelée---Géographie---Martinique",
		"L'étang Grominet pipi---Le lac Titicaca---Géographie---Amérique du Sud",
		"Le travail des huit clans---Le jeu des sept familles---Chanson---\"Père--- mère--- fille...\"",
		"\"Papa, tu as manqué le train\"---\"Maman, j'ai raté l'avion\"---Cinéma---Macaulay Culkin",
		"Ton jeune---Mon vieux---Chanson---Daniel Guichard",
		"Inca la guêpe---Maya l'abeille---Dessin animé---Ruche",
		"Les Maigres Autorités---Les Grosses Têtes---Radio---Philippe Bouvard",
		"La cravache nucléaire---La bombe atomique---Militaire---Arme de destruction massive",
		"Mal arrivé à la maison des flamands---Bienvenue chez les ch'tis---Cinéma---Dany Boon",
		"La brioche de Balzac---La madeleine de Proust---Souvenirs---Nostalgie",
		"Tu es allé m'annoncer que tu partais---Je suis venu te dire que je m'en vais---Chanson---Serge Gainsbourg",
		"La pathologie du boeuf déraisonnable---La maladie de la vache folle---Sciences---Creutzfeld-Jacob",
		"Réponses à un as---Questions pour un champion---Télévision---Jeu télévisé",
		"La sculpture de l'Indépendance---La statue de la Liberté---Monument---New York",
		"Évidence ou cube de crayon---Mystère et boule de gomme---Expression---Énigmatique",
		"Il monte de la vallée---Elle descend de la montagne---Chanson---À cheval",
		"Carnage à la hache---Massacre à la tronçonneuse---Cinéma---Film d'horreur",
		"Une parade de bas tricotage---Un défilé de haute couture---Manifestation---Mannequins",
		"Les Anglodélires---Les Francofolies---Musique---Festival",
		"Les six horreurs de l'humanité---Les sept merveilles du monde---Antiquité---Monuments grandioses",
		"Posséder la peau du coq---Avoir la chair de poule---Expression---Frisson"

	};


}
