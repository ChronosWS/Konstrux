# Welcome to Konstrux
Konstrux is a project aimed at producing a Minecraft-like game with the following properties:
* Highly-extensible, with first-class support for modding
* Modern graphics engine with high quality visuals
* High-performance multi-player, even in modded games
* A more complete RPG-like character system out of the box
* An easy-to-use-and-setup server

## Communications
We have a discord channel here: https://discord.gg/R2Se35Z

## Related Projects
Konstrux is currently composed of two projects:
* Konstrux (this repository)
  * The shared client/server code. Contains the core game mechanics and modding APIs
* KonstruxClient (closed source)
  * Contains the Unity client code. Current closed-source because the plugins required are non-redistributable in source form.

## Project Organization
* `Core`: This is the core code, providing the basic game logic and utilizing the `API` for extensibility
* `API`: The extensibility framework, providing a modding system which external projects may interface with to extend Konstrux.
* `Mods`: Sample and default mods, which utilize the extensibility provided by the API and which are loaded into the client or server at runtime.
* `Server`: The stand-alone server code, which utilizes the `Core` and `API`.

