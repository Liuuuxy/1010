# 1010

A Unity-based puzzle game inspired by the classic 1010! puzzle game. Players place various block shapes onto a grid, aiming to complete rows and columns to clear them and score points.

## Game Description

1010 is a puzzle game where players must strategically place different shaped blocks onto a grid. When a row or column is completely filled, it disappears, making room for new blocks. The game continues until no more blocks can be placed on the grid.

## Features

- Multiple block shapes including:
  - Single blocks (1x1)
  - Line blocks (2-5 blocks long, horizontal and vertical)
  - L-shaped blocks (2x2 and 3x3, in various orientations)
  - Square blocks
  - Gigantic blocks
- Grid-based gameplay
- Score tracking
- Clean, minimalist visual design

## Technical Details

- Built with Unity
- Uses Unity's Tilemap system for grid management
- Implements sprite-based rendering for blocks
- Supports both horizontal and vertical block orientations
- Custom block prefab system for easy shape management

## Project Structure

- `Assets/`
  - `Art/` - Contains sprites and visual assets
  - `Prefabs/` - Block prefabs and reusable game objects
  - `Scenes/` - Game scenes including MainScene
  - `Scripts/` - Game logic and behaviors
    - `Base/` - Core game mechanics
    - `Editor/` - Custom editor scripts
  
## Development

To work on this project:

1. Clone the repository
2. Open the project in Unity (compatible with Unity 2019.4 or later)
3. Open the MainScene in Assets/Scenes/
4. Run the game in the Unity editor to test

## Build

The project can be built for multiple platforms including:
- Windows
- macOS
- Mobile devices (iOS/Android)
- WebGL

