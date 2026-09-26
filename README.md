<div align="center">
  <img src=".github/assets/banner.png" alt="EasySave v1 banner" width="100%" />

  <h1>ProgSyst (EasySave v1)</h1>
  <p>Command-line file backup software, developed in C#, with configuration and log management.</p>

<p>
  <img src="https://img.shields.io/github/last-commit/BaditSad/ProgSyst" alt="last update" />
  <img src="https://img.shields.io/github/languages/top/BaditSad/ProgSyst" alt="top language" />
</p>
</div>

<br />

## :notebook_with_decorative_cover: Table of Contents

- [About](#star2-about)
- [Tech Stack](#space_invader-tech-stack)
- [Features](#dart-features)
- [Installation](#gear-installation)
- [Usage](#eyes-usage)
- [Known Issue](#warning-known-issue)
- [Related Repositories](#link-related-repositories)
- [Contact](#handshake-contact)

## :star2: About

ProgSyst is the repository's name, but the project is actually called EasySave (see the `EasySave` namespace
in the code). It's a command-line backup utility developed as part of my studies: on first launch, the user
picks the application's language (French or English), then reaches a menu to create a backup, view logs, and
configure the application.

The `Diagrams` folder contains the UML diagrams (activity, class, sequence) produced ahead of development.

## :space_invader: Tech Stack

<details>
  <summary>Application</summary>
  <ul>
    <li>C# / .NET</li>
    <li>Console (System.Console)</li>
  </ul>
</details>

## :dart: Features

- Language selection on first launch (French or English)
- Backup creation: source and target folder selection, with a configurable default target path
- Recent action log browsing (daily log)
- Configuration: default path change, language change, log deletion, full application reset (uninstall)

## :gear: Installation

Open `ProgSyst.sln` in Visual Studio and build the `ProgSyst` project.

## :eyes: Usage

Run the generated executable. The main menu offers: create save, show saves, config, close.

## :warning: Known Issue

If the user closes the console on the very first launch, before picking a language, the application no longer
starts. To fix this, delete the `Config` folder at the source code root then relaunch the application.

## :link: Related Repositories

This project is the first version of EasySave. A second version, with a revised architecture, is available in
[EasySave.V2](https://github.com/BaditSad/EasySave.V2).

## :handshake: Contact

Brieuc Dumortier, [LinkedIn](https://www.linkedin.com/in/dumortier-brieuc/), dumortier.contact@gmail.com
