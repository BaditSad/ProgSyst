<div align="center">
  <h1>ProgSyst (EasySave v1)</h1>
  <p>Logiciel de sauvegarde de fichiers en ligne de commande, développé en C#, avec gestion de la configuration et des logs.</p>

<p>
  <img src="https://img.shields.io/github/last-commit/BaditSad/ProgSyst" alt="last update" />
  <img src="https://img.shields.io/github/languages/top/BaditSad/ProgSyst" alt="top language" />
</p>
</div>

<br />

## Table des matières

- [A propos](#a-propos)
- [Stack technique](#stack-technique)
- [Fonctionnalités](#fonctionnalites)
- [Installation](#installation)
- [Utilisation](#utilisation)
- [Problème connu](#probleme-connu)
- [Dépôts liés](#depots-lies)
- [Contact](#contact)

## A propos

ProgSyst est le nom du dépôt, mais le projet s'appelle en réalité EasySave (voir le namespace `EasySave` dans le code). C'est un utilitaire de sauvegarde en ligne de commande développé dans le cadre de mes études : au premier lancement, l'utilisateur choisit la langue de l'application (français ou anglais), puis accède à un menu permettant de créer une sauvegarde, consulter les logs, et configurer l'application.

Le dossier `Diagrams` contient les diagrammes UML (activité, classes, séquences) réalisés en amont du développement.

## Stack technique

<details>
  <summary>Application</summary>
  <ul>
    <li>C# / .NET</li>
    <li>Console (System.Console)</li>
  </ul>
</details>

## Fonctionnalités

- Sélection de la langue au premier lancement (français ou anglais)
- Création d'une sauvegarde : choix d'un dossier source et d'un dossier cible, avec chemin cible par défaut configurable
- Consultation des logs des dernières actions (daily log)
- Configuration : changement du chemin par défaut, changement de langue, suppression des logs, réinitialisation complète de l'application (uninstall)

## Installation

Ouvrir `ProgSyst.sln` dans Visual Studio et compiler le projet `ProgSyst`.

## Utilisation

Lancer l'exécutable généré. Le menu principal propose : create save, show saves, config, close.

## Problème connu

Si l'utilisateur ferme la console au tout premier lancement, avant d'avoir choisi une langue, l'application ne se relance plus. Pour corriger cela, supprimer le dossier `Config` à la racine du code source puis relancer l'application.

## Dépôts liés

Ce projet est la première version d'EasySave. Une seconde version, avec une architecture revue, existe dans [EasySave.V2](https://github.com/BaditSad/EasySave.V2).

## Contact

Brieuc Dumortier, [LinkedIn](https://www.linkedin.com/in/dumortier-brieuc/), dumortier.contact@gmail.com
