# Pulse Protocol

A turn-based rhythm combat game on our own C++ engine, where you memorise each enemy's beat pattern and play it back to attack.

**Screenshots and gameplay video:** https://chloe-gportfolio.netlify.app/projects/pulse-protocol

## About the Game

Pulse Protocol is a turn-based rhythm combat game. Each enemy plays a pattern of key presses on the beat; you memorise it, then reproduce it in time to attack. Team Bloop, eight students, built it for the GAM 250 module on our own C++ engine and editor.

Every fight runs in four phases: a countdown, MEMORIZE, INPUT NOW, and the result. During MEMORIZE the enemy plays its pattern on the beat. During INPUT NOW you repeat it with W, A, S and D, and each press is judged PERFECT, GREAT or MISS. A clean pattern attacks the enemy; a missed one hurts you. Each enemy type has its own rhythm (steady, syncopated, or with gaps), and the final boss mixes them before moving on to random patterns of up to eight keys. The beat clock reads the music's playback position from FMOD rather than counting frames, so timing doesn't drift.

## My Role

I was the project manager and one of the programmers, working mainly on the editor tools, the prefab and layer systems, and the rhythm input and combo feedback.

- **Prefabs and layers (C++):** wrote the engine's prefab system, including linked prefabs, and the layer registry, and worked on saving and loading scenes as JSON, including Play/Stop restoring the scene to how it was before you pressed Play.
- **Editor tools (C++, ImGui):** worked on the editor with two teammates, on the transform gizmo, the Project panel (drag-and-drop prefabs, and turning absolute asset paths into relative ones), the Hierarchy (parent-child grouping) and the Inspector.
- **Input and rhythm feedback (C++ and C#):** as the team's champion for input and debugging, wrote the engine's original keyboard and mouse input manager (later extended with controller support by a teammate) and an early engine-side version of the beat judging. Also worked with our design lead on the C# scripts for the combo key slots and display.
- **Product management:** ran our milestone submissions from M1 to M6, tracking tasks on Notion, keeping file documentation consistent across the codebase, splitting the rubric work with our tech lead, and checking that the build ran before each hand-in. Also wrote the project's editor guide and setup guide.

## Tech Used

- **Languages:** C++20 (engine and editor), C# on .NET 8 (gameplay scripts), C++/CLI (scripting bridge)
- **Graphics:** OpenGL with GLSL 4.5 shaders, GLFW, GLEW, GLM, FreeType
- **Audio:** FMOD
- **Editor UI:** Dear ImGui
- **Serialization:** RapidJSON
- **Build:** CMake, Visual Studio 2022

## How to Build and Run

### Prerequisites (Windows)

- **Visual Studio 2022** with these workloads:
  - Desktop development with C++, including **C++/CLI support for v143 build tools**
  - .NET desktop development
- **CMake 3.20 or newer**, added to your PATH
- **.NET 8.0 SDK**

The .NET 8 runtime DLLs needed for C# scripting are downloaded into `extern/dotnet/bin/` automatically the first time you configure the project.

### Setup

> **FMOD is not included in this repository.** Download the FMOD Engine (Core and Studio API) for Windows from [fmod.com](https://www.fmod.com/download) and place it in `PulseEngine/FMOD_API/`, so that the folder contains `api/core/` and `api/studio/`.

### Build

```bat
run.bat                          :: configure, build and run the editor (default)
run.bat editor [Debug|Release]   :: build and run PulseEditor
run.bat game   [Debug|Release]   :: build and run the game only (PulseProtocol)
run.bat all    [Debug|Release]   :: build every target without running
run.bat sln                      :: open build/PulseEngine.sln
run.bat clean                    :: delete the build folder
```

You can also open `build/PulseEngine.sln` in Visual Studio 2022 after running `run.bat` once. Set either **PulseEditor** or **PulseProtocol** as the startup project, then press F5.

## Download

A ready-to-play Windows installer is available on the [GitHub Releases](../../releases) page.

## Credits

Pulse Protocol was made by an 8-person student team at DigiPen Institute of Technology Singapore.

**Team Bloop**

- Chloe Lau (Product Manager, input & debugging)
- Chia Wei Xuan, Rachael (Tech Lead)
- Ban Kai Wei Benjamin (Programmer, engine)
- Goh Pin Kai (Programmer, graphics)
- Leu Jun Yong (Programmer, gameplay & level design)
- Reginald Lew Yee Ren (Programmer, physics & collision)
- Carrie Lam Tze Ying (Design Lead, audio)
- Chong Sze Ting Fenny (Art Lead)

## Copyright

Copyright (C) 2026 DigiPen Institute of Technology.
Reproduction or disclosure of this file or its contents without the prior written consent of DigiPen Institute of Technology is prohibited.
