# ArduinoTemperatureUI
C# Application to read serial data from Arduino and display temperature.
Changed target Framework to be compatible with Windows 98.

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
   
# Arduino Sketch
Located under: \_Dependencies\Arduino_Sketch\TemperatureSensor.ino

# User Interface
![image](https://user-images.githubusercontent.com/88672050/198045940-de316272-5304-4358-8db8-abc555d37f1f.png)

# Schematics
![image](https://user-images.githubusercontent.com/88672050/198504841-77c3ede9-06e9-40fc-970f-b8570642e08c.png)

# Download Binary
Here you can download the compiled binary file: [ArduinoTemperatureMonitor.zip](https://github.com/BitsUndBolts/ArduinoTemperatureUI/files/9893729/ArduinoTemperatureMonitor.zip)

