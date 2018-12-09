# Minecraft Compatibility notes

Mod assets are designed to be largely Minecraft-compatible for now.  In `3rdParty/MinecraftSamples/<modname>` are Minecraft-style resource directories, as follows:
* `resources/`
    * `advancements`: For the Minecraft achievement system
    * `blockstates`: Description of how blocks are displayed.  Refer to https://minecraft.gamepedia.com/Model for more information.
    * `font`: Font information
    * `lang`: Localizations
    * `loot_tables`: The loot table pool definitions.  See https://minecraft.gamepedia.com/Loot_table for more information.
    * `models`: The model definitions for blocks and items
    * `recipes`: The crafting recipe definitions
    * `sounds`: Sound files for entities and records
    * `shaders`: GLSL shader definitions for Optifine
    * `structures`: Definitions for pre-fabricated buildings in Minecraft format. See https://minecraft.gamepedia.com/Structure_block_file_format.
    * `texts`: Text files for various things like credits, the End scroll, splash screen messages, etc...
    * `textures`: Texture maps for blocks, entities, gui, items, particles and potions, etc...
    * `sounds.json`: Defines when sounds should be played.  See https://minecraft.gamepedia.com/Sounds.json
* `config/`
    * mod-specific configuration files