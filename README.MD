# SkipSplashScreen for SULFUR 0.9.6

**This mod skips the splash screen.**

The splash screen is so quick that I doubt this will be useful to anyone but modders. 

But here you go if you want it anyways.

---

## Requirements and setup

It's pretty bog-standard bepinex Unity modding, but we'll run through the setup just in case you're new to this.

1. Grab `BepInEx-Unity.Mono-win-x64-6.0.0-pre.2.zip` from the [releases section of their github](https://github.com/BepInEx/BepInEx/releases/download/v6.0.0-pre.2/BepInEx-Unity.Mono-win-x64-6.0.0-pre.2.zip). (Direct download link).
2. Extract that into the game's root folder.
3. Run the game once to generate the necessary folders.
4. Download `SkipSplashScreen.zip` from [the releases section of this github repo](https://github.com/remghoost/SkipSplashScreen/releases/).
5. Extract `SkipSplashScreen.zip` into `SULFUR/BepInEx/Plugins`.
6. Done!

---
## Building from source

If you're not comfortable downloading a random `.dll` from a stranger on the internet (which, I don't blame you), you can build this plugin from source.

1. `git clone` this repo.
2. Retarget `PerfectRandom.Sulfur.Gameplay.dll` in `SkipSplashScreen.csproj` to wherever your game exists.
3. `dotnet build`

---
## Considerations
- Shoutout to ChatGPT for always being a homie 
- Submit an issue if you find something wonky.
- **This mod might break some things (it shouldn't though) and comes with no warranty!**