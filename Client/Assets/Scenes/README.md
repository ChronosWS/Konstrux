# Scene Organization and Setup

## Voxel Play Scenes
The scene should have the following root-level, zero-transform game objects, and children:
* Cameras
    * Main Camera
* Lights
    * Directional Light - Note that the Voxel Play Environment will need this attached to it to represent the sun.
* World
    * Voxel Play Environment - see https://kronnect.freshdesk.com/support/solutions/articles/42000001868-voxel-play-environment-options
* GUI
* Management
    * Voxel Play FPS Controller - see https://kronnect.freshdesk.com/support/solutions/articles/42000001874-voxel-play-fps-controller-options
* _Dynamic

## 