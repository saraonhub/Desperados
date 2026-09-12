# DESPERADOS
![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![C%23](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![Figma](https://img.shields.io/badge/Figma-F24E1E?logo=figma&logoColor=white)


> *A short Wild West shootout built in Unity.*

**Desperados** is a small single-level Wild West game centered around **Cora McKoy**, an outlaw carrying out a bank robbery with her trusted partner, **Ranger**, waiting outside.

The game combines combat, exploration, interactive objects, secrets, and custom UI to create a complete beginning-to-end game experience.

<img width="958" height="586" alt="Screenshot 2026-09-10 at 18 37 08" src="https://github.com/user-attachments/assets/7498e308-52d2-4123-89b9-e2bf504abb76" />
<img width="960" height="584" alt="Screenshot 2026-09-10 at 18 37 34" src="https://github.com/user-attachments/assets/cec4c878-0cd3-48c5-bf8d-66524a9d02b1" />
<img width="960" height="589" alt="Screenshot 2026-09-10 at 18 37 51" src="https://github.com/user-attachments/assets/a257cea4-a76c-4c1b-a584-6dbfce98f5c4" />



---
### 🎮 Play the Game

The playable WebGL version of **Desperados** is available on itch.io:

**[▶ Play Desperados](https://sarii24.itch.io/desperados)**

---

## 🎮 Game Overview

The plan is simple: get into the bank, deal with anyone standing in the way, loot the safe, and get out.

Players take control of **Cora McKoy** and must survive the shootout while completing the robbery.

### Features

* 🔫 Top-down shooting combat
* 💰 Bank robbery objective
* 🎯 Objective-based gameplay
* 👀 Hidden secrets to discover
* 🤝 Interactive objects
* 💵 Loot and reward feedback
* ❤️ Player health and death system
* 🔄 Respawning and reload functionality
* 🐎 Ending escape sequence
* 📜 Intro and ending dialogue
* 🖥️ Custom UI throughout the game

---

## 🛠️ Built With

* **Unity 6**
* **C#**
* **Figma**
* **Git**
---
## 👩‍💻 My Role

This project was created independently.

**Roles:**

* Game Design
* Programming
* UI/UX
* Level Design
* Interaction Design
* QA / Testing
* Audio Implementation

The project was created as a portfolio piece to demonstrate the ability to design and implement a complete small-scale game experience, with particular attention to **UI, player feedback, and game flow.
---
## 📚 What I Learned

During development, I gained practical experience with:

* Unity's Input System
* UI state management
* Singleton-based managers
* Screen and popup management
* Interaction systems
* Interfaces in C#
* Coroutines
* Scene / game flow management
* Player health and respawning
* Objective systems
* Collectibles and tracking
* UI feedback and animations
* Audio implementation
* WebGL builds
* Publishing a Unity project on itch.io
---

## 🕹️ Controls

| Input                 | Action   |
| :-------------------- | :------- |
| **WASD**              | Move     |
| **Left Mouse Button** | Shoot    |
| **E**                 | Interact |


---

## 🎯 Gameplay Flow

```text
Title Card
    ↓
Main Menu
    ↓
Intro Dialogue
    ↓
Tutorial
    ↓
Gameplay
 ├── Eliminate all enemies
 ├── Discover hidden secrets
 └── Loot the safe
    ↓
Ending Dialogue
    ↓
Credits
```

---

## 🖥️ UI & UX

UI was one of the main focuses of the project.

The game includes custom interfaces for:

* Main Menu
* Tutorial
* Objectives
* Health
* Ammunition
* Reloading
* Interaction prompts
* Dialogue
* Safe loot feedback
* Secret discovery
* Death / Failed screen
* Job Completed screen
* Credits

The UI was designed to keep the player informed without interrupting the pace of the game.

### Interaction System

Interactive objects use a simple interaction system based around an `IInteractable` interface.

Objects provide visual feedback when the player approaches them, making interactable elements easier to identify.

The safe also changes its interaction behavior depending on the current objective, preventing the player from accessing it before the enemies have been dealt with.

---

## 🔫 Combat

The shooting system includes:

* Six-round magazine
* Reserve ammunition
* Reloading
* Reload feedback
* Muzzle flash
* Shooting audio
* Enemy damage and death
* Player damage and death

The player must manage ammunition while fighting through the bank.

---

## 👀 Secrets

Three hidden secrets can be discovered throughout the level.

Secret collectibles use:

* Interaction detection
* Visual highlighting
* Pickup feedback
* A secrets counter
* Secret inspection / preview UI

Finding all three secrets is an optional challenge for players who explore the level carefully.

---

## 💰 Objectives

The robbery is divided into two main objectives.

### Objective 1

**Eliminate all enemies.**

### Objective 2

**Loot the safe.**

After the first objective is completed, the safe becomes available for interaction.

Looting the safe triggers visual reward feedback and completes the robbery objective.

---

## 💀 Death & Respawning

If Cora loses all of her health, a death sequence is triggered followed by the **Failed** screen.

The player can then reload the level and attempt the robbery again.

---

## 🎨 Visual Style

The project uses a stylized Wild West visual direction, combining the environment, characters, UI, and feedback elements to create a cohesive western atmosphere.
---

## 🎵 Audio

The audio was intentionally kept simple and focused on supporting gameplay.

The game includes:

* Main Wild West soundtrack
* Shooting sound
* Reload sound
* Horse / galloping sound
* UI and gameplay feedback sounds

---

## 📦 External Assets & Credits

This project uses external assets and resources.
All third-party assets remain the property of their respective creators and are used according to their applicable licenses.

### Character Assets

**Universal LPC Spritesheet Generator**

#### `body/bodies/male/walk.png`

See details at [OpenGameArt](https://opengameart.org/content/lpc-character-bases).

*'Thick' Male Revised Run/Climb by JaidynReiman, based on ElizaWy's LPC Revised.*

**Licenses:** OGA-BY 3.0, CC-BY-SA 3.0, GPL 3.0

**Authors:** bluecarrot16, JaidynReiman, Benjamin K. Smith (BenCreating), Evert, Eliza Wyatt (ElizaWy), TheraHedwig, MuffinElZangano, Durrani, Johannes Sjölund (wulax), Stephen Challener (Redshrike)

#### `head/heads/human/male/walk.png`

Original head by Redshrike, tweaks by BenCreating, modular version by bluecarrot16.

**Licenses:** OGA-BY 3.0, CC-BY-SA 3.0, GPL 3.0

**Authors:** bluecarrot16, Benjamin K. Smith (BenCreating), Stephen Challener (Redshrike)

#### `head/faces/male/neutral/walk.png`

Original by Redshrike, expressions by ElizaWy, mapped to all frames by JaidynReiman.

**License:** OGA-BY 3.0

**Authors:** JaidynReiman, ElizaWy, Stephen Challener (Redshrike)

### Additional Assets
* Sprite muzzle flashes by bestgamekits via Unity Assets

### Music

**Wild West Never Sleeps**
by BFCMUSIC via Pixabay

**Western Cinematic** 
by Cornist via Pixabay

[Pixabay track](https://pixabay.com/music/folk-wild-west-never-sleeps-246672/)

**SFX**
* Clean Revolver Reload by Dredile via Pixabay
* Desert Eagle Gunshot by elliotlp via Pixabay
* FC User Interface SFX by fcaudio via Unity Assets


---

## 📄 License

This repository contains an original student / portfolio game project.

The project's original code and original creative work are © **2026 Sara Popović**.

Third-party assets are subject to their respective licenses and are **not** covered by this statement.

---

<p align="center">

**DESPERADOS**
*Created by Sara Popović · 2026*

</p>
