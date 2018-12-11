# Konstrux Mods

Mods should be placed in the Mods folder (this folder) each in their own directory. Each mod must contain at least one file, `modmeta.yaml` describing the mod itself.  All other parts of the mod described below are optional except for this file.

* `Mods\`
  * `modmeta.yaml` - The mod metadata, including name, version, author, etc...
  * `signature` - The mod's signature file, verifying the mod is official (optional)
  * `resources/` - Mod resources (assets) are located here
    * `biomes.yaml` - Biome definitions
    * `blocks.yaml` - Block definitions
    * `voxels.yaml` - Voxel definitions
    * `items.yaml` - Item definitions
    * `worlds.yaml` - World definitions
    * `sounds.yaml` - Sound definitions
    * `models/` - Model definitions
    * `textures/` - Texture files
    * `audio/` - Audio files
    * `loc/` - Localization files

# Mod file details

## `mcmeta.yaml`
Contains the mod metadata, as follows:

```
mod:
  id: mod unique name
  name: mod display name or localized string reference (optional, defaults to id)
  description: mod description
  version: mod version
  gameVersion: min version of the game this mod works with
  siteUrl: url to the mod's website (optional)
  downloadUrl: url where this mod can be officially downloaded (optional)
  authors: (optional)
    - name: author name
      url: author website (optional)
  dependencies: (optional)
    - id: dependency mod name
      minVersion: mod version (optional)
      maxVersion: mod version (optional)
  logo: path to resource within this mod (optional)
  screenshots: (optional)
    - url: url to a screenshot (optional)
      resource: path to resource within this mod (optional)
```

## `signature`

This is the RSA signature of the mod.  If present, it is verified against the actual signature of the mod to validate the contents of the mod have not been altered.

## `resources/`

This directory contains all of the resources used by the mod, such as world, biome, block and item definitions, as well as sounds, textures, fonts and other data files.  It does not include code.

### Resource names and references

Each resource has a *name* associated with it, which is a unique identifier within the mod. When a resource is referred to by some other resource or by the mod code, the *name* is used to find the resource.

Resource names are **case-insensitive**.

Resources may be referred to by name, using the following scheme:
  * Within the same mod: `resource_name`
  * Within another mod: `OtherMod:resource_name`
  * Within the core engine: `:resource_name`

## `resources/worlds.yaml`

This file describes the worlds (dimensions in Minecraft parlance) provided by the mod. A world defines the set and distribution of biomes and what the sky and day/night cycle looks like.

## `resources/biomes.yaml`

This file describes the set of biomes available from this mod. Biomes are usually referenced by world definitions.

## `resources/items.yaml`

This file describes the set of items which are available from this mod.

## `resources/blocks.yaml`

This file describes the set of blocks which are available from this mod. Blocks are made up of voxels, but they may change voxels depending on their state or relative position to other blocks. **DEV NOTE**: see Minecraft blockstates.

## `resources/voxels.yaml`

This file describes the set of voxels which are available from this mod.  A voxel describes a cube or cube-equivalent shape and the textures which are applied to it, which may make up a block.

## `resources/sounds.yaml`

This file describes the sounds available from this mod.

## `resources/audio/`

Audio files references from `sounds.yaml` are placed here.

## `resources/textures/`

Texture files referenced from `voxels.yaml`, `items.yaml` and other resource files are placed here.

## `resources/models/`

Model files describing static voxel constructs like trees and buildings

## `resources/loc/`

Text files containing translations for all displayed strings in the game.  Each file is named according to its RFC 4646 culture name.