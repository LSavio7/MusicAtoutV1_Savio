# 🎼 MusicAtoutV1\_Savio

Projet C# en Windows Forms pour la gestion du festival de musique classique **MusicAtout**.
Développé dans le cadre de la formation **SIO2 PFR 2024-2025**.

## 🎯 Objectifs du projet

* Gérer les **villes**, **bâtiments**, **salles**, **types d'œuvres**
* Visualiser et manipuler les **compositeurs** selon leur **nationalité** et leur **style**
* Implémenter la **sécurisation** via une table UTILISATEUR (authentification, mots de passe hashés)
* Effectuer des **ajouts/modifications/suppressions** d'entités via une interface graphique (LINQ + EF Core)

## 🛠️ Technologies utilisées

* Visual Studio 2022
* C# (.NET 8.0)
* Windows Forms
* SQL Server
* Entity Framework Core
* Git + GitHub

## 📁 Structure du projet

* `Models/` → les classes EF Core mappées aux tables SQL (Ville, Batiment, Style, Compositeur, etc.)
* `Forms/` → interfaces graphiques (FMenu, FGestionUtilisateur, FCompositeurNation, etc.)
* `ModelProjet.cs` → classe statique centrale pour gérer les données
* `Program.cs` → point d'entrée de l’application

## 🔒 Sécurité

* Mots de passe hashés en MD5 (via `System.Security.Cryptography`)
* Tentatives de connexion limitées à 3 (verrouillage du compte)
* Gestion des rôles pour activer/désactiver des comptes
* Obligation de modifier le mot de passe lors de la première connexion

## 📷 Interfaces

Quelques formulaires développés :

* `FConnexion` : écran de connexion sécurisé
* `FGestionUtilisateur` : gestion des utilisateurs
* `FCompositeurNation`, `FCompositeurStyle` : filtrage et affichage des compositeurs

## 📌 Auteur

Projet réalisé par **Leith** sous la supervision de l’équipe pédagogique SIO2.
