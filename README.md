# SmartHunter - Monster Hunter: World Overlay

A complete overlay for Monster Hunter: World on PC with Iceborne support. Originally distributed on [Nexus Mods](https://www.nexusmods.com/monsterhunterworld/mods/793). Features include:

- Monster widget - name, health, parts, status effect buildup, and crown.
- Team widget - name and damage meters.
- Player widget - buff, debuff, and equipment/mantle timers.
- Open source - freely learn from and contribute to the project.
- Skinnable - create and distribute your own rich styles and animations with XAML.
- Easy localization - create and distribute your own translations for our international friends.

## Requirements

- Windows.
- [.NET Framework runtime](https://dotnet.microsoft.com/download/dotnet-framework) (4.6.1 is required 4.8 is recommended).

## How to install

- Download the latest release from [here](https://github.com/sir-wilhelm/SmartHunter/releases).
- Extract the contents of the .
- IMPORTANT: If you are replacing the new `.exe` in the same folder of the old SmartHunter please just follow the instructions `## How to update`.
- You're ready for the hunt.

## How to use

- Launch `SmartHunter.exe`.
- Hold `LeftAlt` to view widget locations.
- Click and drag widgets to move them.
- Scroll over widgets to rescale them.

## How to update

- SmartHunter automatically checks the latest release, and if a new version is released it will auto download, extract, and clean up the old files.
- To disable this feature set `AutomaticallyCheckAndDownloadUpdates` to `false` in `Config.json`.
- You can always grab the latest version from the [releases](https://github.com/sir-wilhelm/SmartHunter/releases) page.

# How to use custom data

- To better support auto updates the .json data files are recreated by default. 
- To change/use custom data files set `UseCustomData` to `true` in `Config.json`.

## How to create and use new localizations

- Create a copy of `en-US.json` and rename it for the locale you are translating to.
- Translate the strings in the second part of each key value pair. Do not change the keys.
- Ensure the new file is in the SmartHunter folder.
- Open `Config.json` and point `LocalizationFileName` to the new file.

## How to create and use new skins

- Create a copy of `Default.xaml` and rename it appropriately.
- Make changes to the new file.
- Ensure the new file is in the SmartHunter folder.
- Open `Config.json` and point `SkinFileName` to the new file.

## Disclaimer

Use with care and at your own risk. It is possible to get banned from games for using mods and overlays. There have been reports of people being banned from other games, such as PUBG, if overlays are accidentally left running in the background. To date, there have been no reports of players being banned from Monster Hunter: World for using mods and overlays, but that doesn't preclude it from happening in the future.
