# Liquid Simulation Extension

This project is an extension of Liquid-Simulation.

## Main features

As of now, there is only a small spawn system and I move some components of Liquid-Simulation into prebabs.

## Running the project

To run the project, open one of the scenes, and run it.

## Importing the project

You can add this package as a git url : 
- "https://github.com/isirode/LiquidSimulationExtension.git?path=/Assets/Isirode/LiquidSimulationExtension#VERSION".
- Replace VERSION by the version you want
- Such as "https://github.com/isirode/LiquidSimulationExtension.git?path=/Assets/Isirode/LiquidSimulationExtension#0.0.1"

The project will be added to your "Packages" folder, the scenes will be read-only, if you want to open them, just copy them in your Assets folder and they will be usable.

~~This will import [Liquid-Simulation](https://github.com/isirode/Liquid-Simulation) automatically.~~

You have to import it manually : import https://github.com/isirode/Liquid-Simulation.git?path=/Assets/Isirode/Liquid-Simulation#0.0.3 as a Git url.

See [this issue](https://forum.unity.com/threads/custom-package-with-git-dependencies.628390/) if you want to know why.

You can also download the .unitypackage of the version you want, here for instance :
- https://github.com/isirode/LiquidSimulationExtension/releases/tag/VERSION
- Replace VERSION by the version you want
- Such as https://github.com/isirode/LiquidSimulationExtension/releases/tag/0.0.3

and add it manually to your project.

This should import the project in your Assets folder.

## Know issues

The water of the waterfall are going up, if you spawn to rapidly, because of the colliders.

The camera system (of Liquid-Simulation) is difficult to use.

The water is sluggish : it will not smooth flat (they are small hills).

## Partipating

Open the [DEVELOPER.md](./DEVELOPER.md) section.

