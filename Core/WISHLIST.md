# Core Wishlist

* Inventory: I'd like inventory to be less micro-management than a Minecraft-type game.
  * Examples of micro-management:
    * Filling your inventory with building blocks to build large-scale structures
    * Having dozens of items from many different mods in inventory because you are constructing some machines
    * Not having combat-necessary items ready on the hotbar because you were recently building stuff and now you are getting attacked
  * Thoughts on how to solve it:
    * Maybe have multiple classes of inventory:
      * For most/all blocks (or maybe blocks in some category), inventory is unlimited. There is a creative-tab-like system that lets you see how many of which kind you have, but they never live in your "active" inventory
      * For things like weapons, armor, and combat-related tools, there is an "active" inventory, which is limited in the number of things you can carry
      * For tools (used to interact with certain kinds of blocks or the world in special but usually non-combat ways) there is a "toolbelt" where these tools may be stored. You can have as many tools as you want, and they can be "context-sensitive", meaning they become available for you to use when you are working on certain blocks, or under certain conditions "build mode?"
      * Maybe other kinds of inventory for other classes of items (like food, health recovery, plants, etc.)
    * Hotbars - there can be hot bars to which you can assign items from active inventory, toolbelt, "skills", building blocks, special items.  Users may freely configure hot bars.
      * Some hotbars may be "special" and "always active", like left and right hands. The "active" item is the one which gets used when the appropriate mouse button is clicked, and you can switch which item from that hotbar is active with a keypress (cycle through weapons/off-hand)
      * Similar hotbar for "health recovery/potions"
      * Can freely assign keys to certain hotbar slots?
      * Hotbars can have items or skills/commands assigned to them

* Magic/Skills: I'd like there to be a first-class skill system.
  * Skills allow non-item-based actions
  * Skills can have "levels" associated with them
  * Skills can be assigned to hotbars/hotkeys
  * Skills don't take up inventory slots

* Stats: What stats should there be?
  * Health
  * Armor?
  * Satiation/Thirst?
  * Stats should probably be a first-class mod-addable thing.  Imagine a magic mod adding some sort of mana...

* "Vanilla" game expressed as a mod:
  * I think ideally the "vanilla" experience is itself a mod built on top of the game engine. We could build out the core experience and use it as a POC for the mod system to help drive requirements.