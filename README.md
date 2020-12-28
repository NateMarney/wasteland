# Project Wastelander
All team members should feel free to change, add to, or edit this document at any time at their disgression. Project name is tentative.

## Overview
Project Wastelander is an attempt at an immersive hardcore first person role-playing sandbox game. The gameplay is focused on first person action (shooting and melee combat), character progression, survival/crafting mechanics, role-playing, and exploration. 

### Elevator Pitch
You role-play as a wanderer-scavenger fighting for survival in a harsh sci-fi world run by a variety of factions that you will come into conflict with. Think "first-person Kenshi".


## Project Scope
### Team
Project Wastelander is created by a three-man team, brothers Angelo and Nathan, and Artist Danilo. Angelo is the lead programmer, but is also in charge of project organization, marketing, and recruitment. Nathan is an assistant programmer, but will mostly be focused on importing and creating including models, textures, animations, and sound effects. Danilo is the (lead?) artist, and will be focus on all sorts of asset creation.

### Budget
The game has a zero dollar budget. Marketing will be done through social media posts (reddit, imgur, twitter, facebook, instagram, tumblr), word of mouth, email lists, sending free review copies, etc. Artists or musicians who join the team later will be offered a percentage of the revenue.

### Timeline
Version 0.1 should be ready to play in about about 3 to 6 months (March to July).


### Monetization
Version 0.1 will be released in early access on Steam to get a community of players interested in the game, and for them to give feedback before the full release. Eventually, there will be a full steam release as well.

## Story
The player will be able to choose from a number of backstories to roleplay from. From there, the only goal is to survive and progress by any means. The lore of the game is mostly centered around the factions, some of which are at odds with one another and some of which are allied, which control large territories all over the map. 

## Gameplay Features

### First-person combat
The core combat will be first-person shooting. There will be wide variety of guns to choose from, including:
- A pistol
- A revolver
- A double-barreled shotgun
- A bolt-action rifle
- An assault-style rifle 
- An SMG
- A missile launcher
- Melee weapons

### Sandbox
The game will be a complete open world. The player will be thrown into the game with their starting gear, and will be free to go and do whatever they please. There will be different "backstories" the player can choose from, which decide the starting location and starting gear of the player. 

### Semi-randomized World
Some aspects of the world will be randomized to allow for more replayability. For example, the outline and terain of the continent is randomized, as well as the location of some of the major landmarks, settlements, and factions.

### Perma-death and World Persistence
When the player dies, they will have to start a new character. However, they will be playing on the same world. The previous player character's actions might have drastically altered the world in permanent ways. For example, past player characters may be mentioned by NPCs, or you might be able to visit the past player character's grave. 

### Survival Mechanics
The player will need to maintain their hunger, health, water, and exhaustion bars. If they fall too low, the player will suffer penalties (to mobility, aim, stamina, health, inventory, etc), or die.

### Locational Damage System
Damage dealt to enemies or players will be localized to specific parts of the body. If you get shot in the arm, you may not be able to hold your weapon steady with it. If you shoot an enemy in the leg, that enemy might no longer be able to walk on that leg.

### Resource Management
The player will have a very limited inventory space, so they will have to manage their inventory carefully. They will have to find safe places to store their belongings. Ammo will also be in limited supply. There will be vendors from which the player can purchase food, ammo, water, and other resources.

### Maintenence
Weapons and armor will have to be maintained regularly or they will cease to function properly (won't be sighted in, might jam, won't fire more than one bullet, might explode). A big part of the game will involve going out and finding parts to replace and maintain your weapons and armor. 

### Weapon Mods
The player will be able to attach modifications to weapons. For example, they may be able to attach scopes, extended magazines, bayonets, change ammo type, change grips, stocks, recoil pads, handguards, bipods, handgrips, etc.

### Factions and Reputation
There will be a lot of factions in the game, some of which tiny, and some of which large and which control a vast amount of land. Your interaction with these factions will determine your reputation with each faction. For example, if you are a known thief to one faction,they may be hostile or try to imprison you for your crimes.



## Game Elements

### Factions

### Locations

## Assets

### Models

#### Textures

#### Rigs/Skeletons

#### Animations

### Sound

#### Sound Effects

#### Music


# Directory structure:
Everything is located in the 'Assets' folder.
- Animation/
	- Clips/
		- Enemies/
		- Player/
			- FirstPerson/
			- ThirdPerson/
		- Vehicles/
		- Weapons/
	- Controllers/
- Art/
	- Fonts/
	- Materials/
		- Enemies/
		- NPCs/
		- Player/
			- FirstPerson/
			- ThirdPerson/
		- Vehicles/
		- VFX/
		- Weapons/
		- World/
	- Models/
		- Enemies/
		- NPCs/
		- Player/
		    - FirstPerson/
		    - ThirdPerson/
		- Vehicles/
		- Weapons/
		- World/
	- Textures
		- Enemies/
		- NPCs/
		- Player/
			- FirstPerson/
			- ThirdPerson/
		- UI/
		- Vehicles/
		- VFX/
		- Weapons/
		- World/
- Audio/
    - Mixers/
    - Music/
    - SFX/
        - Enemies/
        - Player/
        - UI/
        - Vehicles/
        - Weapons/
- Plugins/
- Prefabs/
	- Enemies/
	- Projectiles/
	- UI/
	- Vehicles/
	- VFX/
	- Weapons/
	- World/
- Scenes/ 
	- Scene1/
	- Scene2/
- Scripts/
    - Editor/

## Animation

### Clips
Animation Clips, which are .anim files.

### Controllers
Animation Controllers, which are .controller files.

## Art

### Fonts
Imported or custom fonts. 

### Materials
Materials, which are .mat files, are collections of settings/inputs that a shader needs to render a specific mesh. Each mesh needs a material. 

### Models
Models, which are .fbx or .obj files, are collections of data for defining the geometry of an object. At the very least, a model includes a mesh. For dynamic objects, which we use .fbx files for, models also rigs/animation data. 

### Textures 
Textures, which are .png files, are often used in material (.mat) files to help define the look of an object.

## Audio

### Mixers
Mixers are .mixer files which are used to control aspects of the audio, e.g., volume.

### Music 
.mp3 files for music.

### SFX
.mp3 files for sound effects.

## Plugins
3rd party code, including licenses.

## Prefabs
Prefabs, which are .prefab files, will be used by to build the world.

## Scenes
Scenes, which are .unity files, are the highest level, or "parent" object in Unity. 

## Scripts
Scripts, which are .cs files, are C# files to add functionality to the game. Often, they are attached as components to objects to add functionality.




