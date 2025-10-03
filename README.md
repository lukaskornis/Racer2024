# Vehicle steering & path planning

A C#, Unity-based racing demo featuring AI-driven vehicles with pathfinding algorithms and physics-based vehicle dynamics.

[Play WebGL here!](https://play.unity.com/en/games/6e32a1e0-da7d-4134-9d21-86b9acf70cac/1)

<img height="250" alt="paveikslas" src="https://github.com/user-attachments/assets/12aca257-aa80-44a2-9e88-586d0569538e" />
<img height="250" alt="paveikslas" src="https://github.com/user-attachments/assets/ee0d7174-d9d4-4aa0-80d1-ff908532e010" />


Modular design ensures DRY priciples. Both AI and player inputs can control the vehicle trough a shared interface.
<img width="321" height="415" alt="paveikslas" src="https://github.com/user-attachments/assets/9a1c5685-f623-41c2-b6cb-fea6f0765d16" />

## Key Features

- **AI Pathfinding System**: Custom pathfinding implementation using waypoint navigation with closest-point detection algorithms
- **Physics-Based Vehicle Dynamics**: Realistic vehicle movement using Unity's Rigidbody physics with acceleration, deceleration, and turning mechanics
- **Component-Based Architecture**: Modular design with separate Vehicle, Player, Brain, and Camera components following Unity's component system
- **Audio Integration**: Dynamic engine sound system with pitch modulation based on vehicle speed using AnimationCurve interpolation
- **Camera System**: Smooth camera following with dynamic field-of-view adjustment based on vehicle speed
- **Input Handling**: Clean input abstraction layer supporting both player and AI control systems
