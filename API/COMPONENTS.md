# API Components

## Registries
A registry is a collection of objects - usually definitions - which map a name and id to some data.  Registries are used to record definitions of many kinds of objects, such as:
* voxels
* items
* biomes
* dimensions
* mobs

Each registry entry has the following properties:
* `Name` - the unique name of the item within the registry. May be any valid string
* `Id` - the unique id within the registry. When items are added to the registry, they will receive the next unused id.
* Data - some data which is specific to the type of registry

Registries are typically saved with a world when a session ends and reloaded when a new session with that world starts. It is expected that the `Id` of each item in the registry remains unchanged for the lifetime of the world.