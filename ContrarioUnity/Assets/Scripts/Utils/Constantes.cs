﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constantes
{
	// SCENE
	public const string SCENE_WELCOME = "MainScene";
	public const string SCENE_PLAYER_SETTINGS = "PlayerSettingsScene";
	public const string SCENE_GAME = "GameScene";
	public const string SCENE_PACK_SELECT = "PackSelectScene";
	public const string SCENE_TUTORIAL = "TutorialScene";


	public static readonly List<string[]> WORDS_AND_DEFS = new List<string[]> {
		new string[] {
			"Zeste aventure---Pulp fiction---Cinéma---John Travolta",
			"Un siphon à arôme---Une pompe à essence---Appareil---Super ou sans plomb",
			"Tu as répondu au soleil---J'ai demandé à la lune---Chanson---Indochine",
			"Péter la bicoque---Casser la baraque---Expression---succès",
			"Des sottises de Roubaix---Des bêtises de Cambrai---Spécialité---Bonbons",
			"La haine devient bébé du Tyrol---L'amour est enfant de Bohème---Musique---Carmen",
			"Celles qui me détestent attraperont un taxi---Ceux qui m'aiment prendront le train---Cinéma---Patrice Chéreau",
			"Plan Blanc---Carte Noire---Marque---Try to remember",
			"Un Joseph allonge-moi ici---Une Marie couche-toi là---Surnom---Fille facile",
			"La Colossale Librairie---La Grande Bibliothèque---Monument---Fraçois Mitterrand",
			"Les six enfoirés---Les douze salopards---Cinéma---Film de guerre",
			"30 milliards d'abstinents---60 millions de consommateurs---Presse---Comparatif d'achats",
			"Les chaînes de division---Les tables de multiplication---Éducation---Arithmétique",
			"Avenue de la Guerre---Rue de la paix---Lieu---Très côtée au Monopoly",
			"La palissade de Munich---Le mur de Berlin---Histoire---Allemagne",
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
			"L'Association Particulière des Oisifs---La Confédération Générales des Travailleurs---Organisme---Syndicat",
			"Mousse de terre ferme---Marin d'eau douce---Expression---Matelot inexpérimenté",
			"Les Sobres Identifiés---Les Alcooliques Anonymes---Association---Thérapie de groupe",
			"Le boeuf et le geôlier---La vache et le prisonnier---Cinéma---Fernandel",
			"C'est mauvais contre le physique---C'est bon pour le moral---Chanson---La Compagnie Créole",
			"Les ruptures tranquilles---Les liaisons dangereuses---Cinéma---John Malkovitch",
			"Les argentés fabriquent de la planche---Les bronzés font du ski---Cinéma---Michel Blanc",
			"Se trouver coupé tel les maïs---Être fauché comme les blés---Expression---Sans argent",
			"Un lézard à clochette---Un serpent à sonnette---Reptile---Crotale",
			"Expédié ordinaire---Envoyé spécial---Télévision---Magazine d'information",
			"Une ronde de truie---Un tour de cochon---Expression---Vilain coup",
			"Périple à la surface du monde---Voyage au centre de la terre---Littérature---Jules Verne",
			"Réapparition sur le passé---Retour vers le futur---Cinéma---Voyage dans le temps",
			"Récolte Réclame---Culture Pub---Télévision---M6",
			"Ton tourniquet à toi---Mon manège à moi---Chanson---Edith Piaf",
			"Le grand tuteur communiste---Le petit chaperon rouge---Littérature---Charles Perrault",
			"Le mois suivant, tu enfiles le haut---La semaine prochaine, j'enlève le bas---Slogan---Affichage",
			"La saison des fraises---Le temps des cerises---Chanson---Jean-Baptiste Clément",
			"La Traversée de la Gaule---Le Tour de France---Cyclisme---Maillot jaune",
			"Relâche-toi quand je veux---Arrête-moi si tu peux---Cinéma---Steven Spielberg",
			"Le Théâtre République---L'Opéra Bastille---Monument---Construit sous Mitterand",
			"Papa les grands navires---Maman les petits bateaux---Chanson---Pour les enfants",
			"Un déjeuner quasi raté---Un dîner presque parfait---Télévision---M6",
			"Acheter la boucle---Vendre la mèche---Expression---Dévoiler un secret",
			"La plaine Épluchée---La montage Pelée---Géographie---Martinique",
			"L'étang Grominet pipi---Le lac Titicaca---Géographie---Amérique du Sud",
			"Le travail des huit clans---Le jeu des sept familles---Chanson---Père, mère, fille...",
			"Papa, tu as manqué le train---Maman, j'ai raté l'avion---Cinéma---Macaulay Culkin",
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
			"Vous ne possédez pas les différentes actions---Nous n'avons pas les mêmes valeurs---Slogan---Rillettes Bordeau Chesnel",
			"Une parade de bas tricotage---Un défilé de haute couture---Manifestation---Mannequins",
			"Les Anglodélires---Les Francofolies---Musique---Festival",
			"Les six horreurs de l'humanité---Les sept merveilles du monde---Antiquité---Monuments grandioses",
			"Posséder la peau du coq---Avoir la chair de poule---Expression---Frisson",
			"La haine sans moi---L'amour avec toi---Chanson---Michel Polnareff",
			"Le tuyau apéritif---Le tube digestif---Médecine---Anatomie",
			"Carboniser les skis---Brûler les planches---Expression---Théâtre",
			"La Petite-Normandie---La Grande-Bretagne---Géographie---Angleterre et compagnie",
			"La femme qui pesait six millions---L'homme qui valait trois milliards---Télévision---Bionique",
			"Pleur et Musiques---Rire et Chansons---Média---Radio",
			"Tenir une bagnole---Lâcher une caisse---Expression---Mauvaise odeur",
			"Un choc de godasse---Un coup de pompe---Expression---Fatigue subite",
			"Maison du Sud---Hôtel du Nord---Cinéma---Louis Jouvet",
			"Le Calgon de Bruxelles---L'Ajax d'Amsterdam---Football---Club hollandais",
			"Le Taureau qui pleure---La Vache qui rit---Marque---Fromage",
			"Mauvaise lignée de bonjour---Bon sang de bonsoir---Expression---Juron",
			"Le donjon de Florence---La tour de Pise---Monument---58 mètres de haut",
			"Des branches et des réacteurs---Des racines et des ailes---Télévision---Reportages",
			"Je viendrai vomir sous nos cercueils---J'irai cracher sur vos tombes---Littérature---Boris Vian",
			"Fabriquer la patte de merle---Faire le pied de grue---Expression---Attendre en vain",
			"Le Roi Einstein du Panaché---Le Prince Albert de Monaco---Souverain---Monte-Carlo",
			"Le coiffeur de Barcelone---Le barbier de Séville---Musique---Rossini",
			"Ton empire contre un chameau---Mon royaume pour un cheval---Citation---Shakespare",
			"Escalier contre guillotine---Ascenseur pour l'échafaud---Cinéma---Louis Malle",
			"La raison des décadences---La folie des grandeurs---Cinéma---Louis de Funès",
			"Soit gigolos soit révoltés---Ni putes ni soumises---Association---Féministe",
			"Un concombre de l'attaque---Un avocat de la défense---Profession---Juridique",
			"Une cruche d'assemblée---Un pot de chambre---Objet---Urine",
			"Brooklyn Bagdad---Manhattan Kaboul---Chanson---Axelle Red et Renaud",
			"Pâques ton père---Noël Mamère---Politique---Écologie",
			"Aventure Europa---Saga Africa---Chanson---Yannick Noah",
			"La virgule vivante---Le point mort---Automobile---Boîte de vitesse",
			"La robe ne crée pas la religieuse---L'habit ne fait pas le moine---Expression---Apparences",
			"La déviation des océans---La dérive des continents---Sciences---Géologie",
			"Le cahier de la steppe---Le livre de la jungle---Cinéma---Walt Disney",
			"Le sacrifice du sérum---Le don du sang---Sciences---Transfusion",
			"Une grande mélodie de jour---Une petite musique de nuit---Musique---Mozart",
			"Une poulette de cercueil---Une canette de bière---Objet---Boisson",
			"Personne en terrasse---Du monde au balcon---Expression---Généreuse",
			"Encaisser en argent de gorille---Payer en monnaie de singe---Expression---Récompenser par de belles paroles",
			"Un prénom sale---Un nom propre---Grammaire---Prend une majuscule",
			"Dans la pénombre de la Terre---Au clair de la Lune---Chanson---Plume et chandelle",
			"Berlin Compétition---Paris Match---Presse---Réputé pour ses photos",
			"Le tigre et la souris---Le lion et le rat---Littérature---Jean de La Fontaine",
			"Un franchissement de steppe---Une traversée du déset---Expression---Éclipse temporaire",
			"Un couple en argent---Une famille en or---Télévision---Jeu télévisé",
			"Les voitures-moustiques---Les bateaux-mouches---Transport---Sur la Seine",
			"Maison Florida---Hotel California---Chanson---Eagles",
			"Une moquette de ré---Un tapis de sol---Objet---Gymnastique",
			"Un pêcheur de gueules---Un chasseur de têtes---Profession---Recrutement",
			"Endroit autorisé---Zone interdite---Télévision---Reportages",
			"Une geôle d'ascenceur---Une cage d'escalier---Lieu---Immeuble",
			"Contre toi la mort va finir---Pour moi la vie va commencer---Chanson---Johnny Hallyday",
			"Une chambre d'incertitude---Une pièce à conviction---Juridique---Enquête policière",
			"Sortir la prose de la bouche---Tirer les vers du nez---Expression---Obtenir des informations",
			"Le pardon de la couleuvre à duvet---La vengeance du serpent à plumes---Cinéma---Coluche",
			"Une attache de plaines---Une chaîne de montagnes---Géographie---Relief",
			"Une pantoufle aux poires---Un chausson aux pommes---Cuisine---Pâtisserie",
			"Tu souhaites de l'ombre---J'veux du Soleil---Chanson---Au P'tit Bonheur",
			"Sauté de terre---Tombé du ciel---Chanson---Jacques Higelin",
			"Un long-potage---Un court-bouillon---Cuisine---Poisson",
			"Le contrat des coyotes---Le pacte des loups---Cinéma---Christophe Gans",
			"Une barque de secours---Un canot de sauvetage---Objet---Embarcation",
			"La pêche aux magots---La chasse aux trésors---Jeu télévisé---Philippe de Dieuleveult",
			"Le Limousin Incarcéré---Le Dauphiné Libéré---Journal---Course cycliste",
			"L'Appartement du Cacao---La Maison du Café---Marque---Pour démarrer la journée",
			"Le Londres-Abidjan---Le Paris-Dakar---Sport---Compétition",
			"Réveille-toi, Coca ma grande soeur---Fais ddo, Colas mon p'tit frère---Chanson---T'auras du lolo",
			"Relâcher la clef---Serrer la pince---Expression---Salut",
			"Restituer les montres de retard---Remettre les pendules à l'heure---Expression---Mise au point",
			"La décade des ombres---Le siècle des lumières---Histoire---Philosophes",
			"L'Auberge-Diable---L'Hôtel-Dieu---Médecine---Hôpital",
			"Le jeter du tournevis---Le lancer de marteau---Sport---Discipline olympique",
			"Les étangs de Cornouailles---Les lacs du Connemara---Chanson---Michel Sardou",
			"Vrai bol---Faux cul---Expression---Hypocrite",
			"Les vilains camps de travail---Les jolies colonies de vacances---Chanson---Pierre Perret",
			"Le Château des Évêques---Le palais des Papes---Monument---Avignon",
			"La mort est une courte rivière impétueuse---La vie est un long fleuve tranquille---Cinéma---Étienne Chatiliez",
			"Un lichen au cacao---Une mousse au chocolat---Cuisine---Dessert",
			"Cela c'est faussement moi--- Ça c'est vraiment toi---Chanson---Téléphone",
			"Un chef des toilettes---Un directeur de cabinet---Activité professionnelle---Bras droit d'un ministre",
			"Sept jours en avion---Cinq semaines en ballon---Littérature---Jules Verne",
			"Les Défaites de la Chanson---Les Victoires de la Musique---Télévision---Trophées",
			"Guidon dur---Pédale douce---Cinéma---Fanny Ardant",
			"Le boudin et le richard---La belle et le clochard---Cinéma---Walt Disney",
			"Le mulot des bourgs et la musaraigne des prairies---Le rat des villes et le rat des champs---Fable---Jean de La Fontaine",
			"Prendre son pied dans l'eau---Mettre sa main au feu---Expression---Certitude",
			"Twist Colocataire---Roch Voisine---Musique---Chanteur canadien",
			"Le Canard de Donald---Le Journal de Mickey---Presse---Enfantine",
			"Un moustique goth---Un cousin germain---Personne---Lien de parenté",
			"La baguette magique---La flûte enchantée---Musique---Mozart",
			"Le merle et le fennec---Le corbeau et le renard---Littérature---Jean de La Fontaine",
			"Le prénom du bégonia---Le nom de la rose---Cinéma---Sean Connery",
			"Une faucille voleuse---Un marteau-piqueur---Objet---Outil de travaux publics",
			"Cumin, ferme-moi !---Sésame, ouvre-toi !---Citation---Ali Baba",
			"Adieu Bobigny---Tchao Pantin---Cinéma---Coluche",
			"Écluse Moins---Canal Plus---Télévision---Chaîne",
			"Respirer le félin---Sentir le fauve---Expression---Mauvaise odeur",
			"Une assiette rampante---Une soucoupe volante---Objet---Extraterrestre",
			"Le lion rouge---La panthère rose---Télévision---Dessin animé",
			"Le conflit des sillons---La guerre des tranchées---Histoire---Verdun",
			"Un pipeau de Peter---Une flûte de Pan---Musique---Instrument",
			"Une virgule de flotte---Un point d'eau---Lieu---Oasis",
			"La femme de Mexico---L'homme de Rio---Cinéma---Jean-Paul Belmondo",
			"Se placer en file d'échalotes---Se mettre en rang d'oignons---Expression---Serrer les rangs",
			"Les Autorités Molles---Les Têtes Raides---Musique---Groupe",
			"Des verres de lune---Des lunettes de soleil---Objet---Se portent souvent en été",
			"Les énigmes de l'Est---Les mystères de l'Ouest---Cinéma---Will Smith",
			"Les virgules évêques---Les points cardinaux---Géographie---4 directions",
			"Souteneur Canard---Mac Donald---Marque---Chaîne de restaurants",
			"Etendre la moquette verte---Dérouler le tapis rouge---Expression---Accueillir avec les honneurs",
			"Empêche-toi de valser---Laissez-moi danser---Chanson---Dalida",
			"Le Chapon Pantouflard---Le Coq Sportif---Marque---Sport",
			"Six mois de cogitation---Sept ans de réflexion---Cinéma---Marilyn Monroe",
			"Casser le carreau---Crever la dalle---Expression---Grande faim",
			"Ton obligation de réfléchir---Ma liberté de penser---Chanson---Florent Pagny",
			"Le régime de Contrex---Le gouvernement de Vichy---Histoire---Pétain",
			"La péninsule de Noël---L'île de Pâques---Géographie---Pacifique sud",
			"François le bizarre---Claude Lelouch---Cinéma---Réalisateur",
			"Partir moins bas---Aller plus haut---Chanson---Tina Arena",
			"Une réprimande de Lyon---Un savon de Marseille---Objet---Propreté",
			"Une poitrine de bourricot---Un dos d'âne---Construction---Route",
			"Les Prolochiens---Les aristochats---Dessin animé---Walt Disney",
			"Prends-lui les tennis---Lâche-moi les baskets---Expression---Foutre la paix",
			"Le magot privé---Le trésor public---Economie---Impôt",
			"Le sucre et les guêpes---Le miel et les abeilles---Télévision---Série",
			"Un verger de têtes---Un champ de mines---Lieu---Militaire",
			"Balancer la serpière---Jeter l'éponge---Expression---Abandonner",
			"Un dénonce-patron---Un couvre-chef---Objet---Chapeau",
			"Une baguette d'aromates---Un pain d'épices---Cuisine---Pour le goûter",
			"La peluche qui dit oui---La poupée qui fait non---Chanson---Michel Polnareff",
			"Une réunion particulière---Une assemblée générale---Juridique---Actionnaires",
			"Télécopies de ton meunier---Lettres de mon moulin---Littérature---Alphonse Daudet",
			"Adieu les Martiens---Salut les Terriens---Télévision---Thierry Ardisson"
		},
		new string[] {
			"P2 : Adieu les Martiens---Salut les Terriens---Télévision---Thierry Ardisson",
			"P2 : Télécopies de ton meunier---Lettres de mon moulin---Littérature---Alphonse Daudet",

		}
	};



}
