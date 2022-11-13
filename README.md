# Arduino Sensors
C# Application to read serial data from Arduino and display temperatures and voltage.<br>
The target .NET Framework is 2.0 to be compatible with Windows 98.

# Dependencies
- Microsoft .NET Framework 2.0 (Source: http://www.oldversion.com/windows/net-framework-2-0)
- Microsoft Windows Installer 2.0 (Source: https://archive.org/details/instmsi)
- Microsoft Internet Explorer 5.01 (Source: https://winworldpc.com/download/46e28093-2511-18c3-9a11-c3a4e284a2ef)
- Arduino Serial Driver

# Installation order
1) Microsoft Windows Installer 2.0 (URL provided above)<br />
   *You most likely will be asked to restart your PC after installation*
   
2) Microsoft Internet Explorer 5.5 (URL provided above)<br />
   *Just go for minimal and update the browser only*
   *You most likely will be asked to restart your PC after installation*

3) Microsoft .NET Framework 2.0 (URL provided above)<br />
   *Will take a long time to install - be patient*
   *You most likely will be asked to restart your PC after installation*

4) Arduino Serial Driver (\_Dependencies\Arduino_Serial_Driver\SETUP.EXE)<br />
   *A bit complex... When asked for file 'CH341SER.CAT', please navigate to '_Dependencies\Arduino_Serial_Driver'*<br />
   *When asked for file 'CH341PORTS.DLL', you can try to select the file. It did not work for me. I skipped this file. Installation still worked.*
   
# Arduino Sketch (temperature and voltage)
Located under: \_Dependencies\ArduinoSensors\ArduinoSensors.ino

# User Interface
![image](https://user-images.githubusercontent.com/88672050/201484735-b7d8633e-8e13-4291-9762-7a56df95f6ff.png)

# Schematics

## Temperature Sensor
![image](https://user-images.githubusercontent.com/88672050/198504841-77c3ede9-06e9-40fc-970f-b8570642e08c.png)

## Voltage Sensor

> __Warning__<br />
Do not measure higher voltages than 12V DC. The absolute maximum is ~15V!

![image](https://user-images.githubusercontent.com/88672050/201532348-7270c64c-3323-4ede-b220-b070b2d0c8e6.png)

# Binary file download
Precompiled version: [ArduinoSensors.zip](https://github.com/BitsUndBolts/ArduinoSensors/files/9995447/ArduinoSensors.zip)

# YouTube Video
Here is a video I have uploaded to YouTube where I use the content of this repository:
- coming soon -
