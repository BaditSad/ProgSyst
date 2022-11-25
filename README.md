# ProgSyst
Lors du premier lancement du logiciel, il est demandé de choisir le langage de l’application. 2 choix sont proposés : français et anglais. Ensuite, le menu d’accueil s’affiche. Sur ce dernier 4 actions sont proposées : creat save, show saves, config et close.
« Close » permet de fermer l’application.
« Create save » permet de créer la sauvegarde. Lorsque cette option est sélectionnée, il est demandé de sélectionner un dossier source qui sera le dossier à déplacer. Il faut ensuite choisir le dossier cible qui est le dossier dans lequel les fichiers du dossier source seront déplacés. Si besoin, il existe un chemin cible qui a été défini par défaut lors du premier lancement de lancement de l’application (dossier dans lequel l’application est installée) et qui sera utilisé si l’utilisateur ne saisit rien et presse « entrer ». Une confirmation est demandée à l’utilisateur avant d’effectuer l’action.
« Show saves » permet d’afficher le fichier « daily log », c’est-à-dire les logs des dernières actions effectuées sur l’application.
« Config » permet de changer certains paramètres de l’application. 4 actions sont disponibles dans ce sous-menu :
  -	« Set default path » qui permet de changer le default path selon les souhaits de l’utilisateur
  -	« Language » permet de changer la langue de l’application
  -	« Clear log » permet de supprimer le fichier log (un nouveau fichier log sera créé à la prochaine action réalisée avec l’application)
  -	« Uninstall » permet de reset l’application et de la relancer comme si c’était la 1ère fois

Un problème a été révélé lors du développement de cette v1.0 de EasySoft qui est le suivant. Lorsque le message de bienvenue s'affiche au premier lancement, il faut choisir une langue. Si l'utilisateur prend l'initiative de fermer la console sans faire de sélection et qu'il décide de relancer le programme, le programme ne se lancera pas. Pour corriger ce problème si jamais le programme ne fonctionne plus : Supprimer le dossier "Config" à la racine du code source.

Le logiciel s’installe par défaut dans le dossier suivant : C:\Users\user\Source\Repos\BaditSad\ProgSyst\ProgSyst
La configuration minimale requise est la suivante : 
Les fichiers de configuration sont stockés dans le dossier suivant :
