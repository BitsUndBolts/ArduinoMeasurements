# ArduinoTemperatureUI
C# Application to read serial data from Arduino and display temperature.
Changed target Framework to be compatible with Windows 98.

# Dependencies
- Microsoft .NET Framework 2.0
- Microsoft Windows Installer 2.0
- Microsoft Internet Explorer 5.01
- Arduino Serial Driver

# Installation order
1) Microsoft Windows Installer 2.0 (\_Dependencies\Microsoft Windows Installer 2.0.exe)<br />
   *You most likely will be asked to restart your PC after installation*
   
2) Microsoft Internet Explorer 5.5 (\_Dependencies\Internet Explorer 5.5\IE5SETUP.EXE)<br />
   *Just go for minimal and update the browser only*

3) Microsoft .NET Framework 2.0 (\_Dependencies\dotnetfx_2.0.exe)<br />
   *Will take a long time to install - be patient*

4) Arduino Serial Driver (\_Dependencies\Arduino_Serial_Driver\SETUP.EXE)<br />
   *A bit complex... When asked for file 'CH341SER.CAT', please navigate to '_Dependencies\Arduino_Serial_Driver'*<br />
   *When asked for file 'CH341PORTS.DLL', you can try to select the file. It did not work for me. I skipped this file. Installation still worked.*
   
# Arduino Sketch
Located under: \_Dependencies\Arduino_Sketch\TemperatureSensor.ino

# User Interface
![image](https://user-images.githubusercontent.com/88672050/198045940-de316272-5304-4358-8db8-abc555d37f1f.png)

# Schematics
![image](https://user-images.githubusercontent.com/88672050/198504841-77c3ede9-06e9-40fc-970f-b8570642e08c.png)
