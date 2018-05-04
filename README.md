# FakeSlice
Discharge USB-C Power Banks instead of charging internal battery on newer ThinkPads, allowing them to function as a swappable "Slice Battery".

## Dependencies

This application requires Lenovo Vantage to be installed, but doesn't require you to have it running. More specifically, the System Interface Package that comes bundled with Lenovo Vantage is required. You will also need two specific DLLs that come with the application. Since these files are proprietary code, they cannot be included. However, the included `CopyDLLs.bat` script should copy the dependencies from their default installation location to the directory it is ran from.

## Build

Just throw `FakeSlice.cs` into your favorite C# compiler, target .NET Framework 4.5, and add the two required references - `Plugins.Battery.Think.Native.dll` & `Lenovo.Modern.Portable.Battery.dll`, then compile as Windows Application. 

## Run

The included release binary will toggle your setting when launched without any commandline arguments. Running the application with the argument `on` will turn the FakeSlice "on" - which will disable charging and run off your Power Bank. Running the application with the argument `off` will turn the FakeSlice "off" and charge the internal battery. This should allow you to use FakeSlice in your scripts with ease, and without any arguments FakeSlice works great when bound to a hotkey (ike `Fn + F12`) using Lenovo Vantage.

## To-Do

Fakeslice currently only supports single battery ThinkPads. Support for Power Bridge enabled systems should be coming in a few days, which will allow you to disable internal battery charging. The current version will only disable charging the battery internally marked as the primary.

### Credits to [Ciastix](https://github.com/Ciastex) for helping expose Lenovo's proprietary interface.
