# Konstrux Mods

Mods should be placed in the Mods folder (this folder) each in their own directory. Each mod must contain at least one file, `modmeta.yaml` describing the mod itself.  All other parts of the mod described below are optional except for this file.

* `Mods\`
  * `modmeta.yaml` - The mod metadata, including name, version, author, etc...
  * `signature` - The mod's signature file, verifying the mod is official (optional)
  * `resources\` - Mod resources (assets) are located here

# Mod file details

## mcmeta.yaml
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