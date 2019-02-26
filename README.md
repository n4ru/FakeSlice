# FakeSlice
Discharge USB-C Power Banks instead of charging internal battery on newer ThinkPads, allowing them to function as a swappable "Slice Battery".

## Dependencies

This application requires Lenovo Vantage to be installed, but doesn't require you to have it running. More specifically, the System Interface Package that comes bundled with Lenovo Vantage is required. You will also need two specific DLLs that come with the application. Since these files are proprietary code, they cannot be included. However, the included `CopyDLLs.bat` script should copy the dependencies from their default installation location to the directory it is ran from.

## Build

This step is optional, you can use the provided [release](https://github.com/n4ru/FakeSlice/releases/latest).

Just throw `FakeSlice.cs` into your favorite C# compiler, target .NET Framework 4.5, and add the two required references - `Plugins.Battery.Think.Native.dll` & `Lenovo.Modern.Portable.Battery.dll`, then compile as Windows Application. 

Alternatively, change to the directory where the DLLs and `FakeSlice.cs` are and run the following: `\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /platform:x86 FakeSlice.cs /r:Lenovo.Modern.Portable.Battery.dll /r:Plugins.Battery.Think.Native.dll`.

## Run

Running the application with the argument `on` will turn the FakeSlice "on" - which will disable charging and run off your Power Bank. Running the application with the argument `off` will turn the FakeSlice "off" and charge the internal battery. Running the application without any commandline arguments will toggle your setting when launched. This should allow you to use FakeSlice in your scripts with ease, and without any arguments FakeSlice works great when bound to a hotkey (like `Fn + F12`) using Lenovo Vantage.

### Credits to [Ciastix](https://github.com/Ciastex) for helping expose Lenovo's proprietary interface.
