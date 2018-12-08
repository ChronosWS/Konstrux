# Mod Assets
This directory should contain the assets which describe the mods for the system. Presently these are "Minecraft-style" assets, as found in the `resources/assets/<mod name>` folder of a Minecraft mod.
For example, if one looked at the Biomes o' Plenty mod, there is a `src/main/resources/assets/biomesoplenty` folder, which contains the following subdirectories:
* advancements
* blockstates
* lang
* loot_tables
* models
* recipes
* sounds
* textures
* sounds.json
Additionally, the config directory contains files used to configure the running mod beyond just resources.  Typically `config` contains user-editable files which can potentially be re-written by the game at run-time, while `resources` contains data files which are read-only.  These config files often can only be found after having loaded and run a game with the mod enabled.
