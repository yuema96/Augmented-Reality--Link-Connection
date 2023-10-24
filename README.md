# Augmented-Reality--Links-Connection
This project uses AR links to connect two screens. The line will be automatically rendered and follow the screens. 

YouTube link is here for the demo: https://youtu.be/BI-a3SAifX4

There are two applications for this project. The first one is the AR Hololens2 side application (WebSocket_AR.zip), and the other one is the monitor side application (multi_window.zip). 

AR Application Instructions:
Versions: 
Unity: 2020.3.34f1
Mixed Reality Toolkit (MRTK): 2.8.0.0
NuGet: 3.0.5, download the WebSocketSharp-netstandard (version 1.0.1) This is for the WebSocket connection between the AR application and the monitor side applications. 
Vuforia: 10.7.2

How to run it:
Make sure use same versions as I listed for all the tools
File--Build Settings—device (Scroll down and select HoloLens), create a new folder build or any other name in the project source folder. Inside the build folder, start to build the app.
Open the build folder, run the .sln file and will use the visual studio to configure the app to the HoloLens. 
My project needs two pictures which are previously uploaded in the Vuforia database. One is a full-screen size laptop screenshot (screen1.png), and the other one is the full-screen size iPad screenshot picture(screen2.png). Need to have two devices displaying those two pictures. 
Run the app in HoloLens2 and look towards to the two devices which are displaying the two pictures. The Bezier curve will connect these two devices together, and you can feel free to move either device, the Bezier curve will catch the movement, and keep updating to the newest position. Once the location is confirmed, we can change the monitor screens to display any other content, and the Bezier curve will still connect two devices together. 

-------------------------------------------------------------------------------------------------------------------------------
Monitor Side Application 
Versions:
'multi-window': '1.0.0',
  npm: '8.11.0',
  node: '16.15.1',
  v8: '9.4.146.24-node.21',
  uv: '1.43.0',
  zlib: '1.2.11',
  brotli: '1.0.9',
  ares: '1.18.1',
  modules: '93',
  nghttp2: '1.47.0',
  napi: '8',
  llhttp: '6.0.4',
  openssl: '1.1.1o+quic',
  cldr: '40.0',
  icu: '70.1',
  tz: '2021a3',
  unicode: '14.0',
  ngtcp2: '0.1.0-DEV',
  nghttp3: '0.1.0-DEV'

How to run it:
Click the multi-window folder, inside the folder, open Git Bash. 
In the Git Bash terminal, type npm start. Below is the screenshot. 

![image](https://github.com/yuema96/Augmented-Reality--Link-Connection/assets/57729954/e1eb9fe3-97d2-44ff-b553-bebcdd6ae8fe)


The multi windows app will start and will automatically create two windows. One is the main window and the other one is the child window. 
You can move the two windows to any position or resize them, and in the terminal, the newest position and width, length information will be returned. 

This app is going to use WebSocket to pass the windows information to the hololens2 AR app, it is not connected yet, but will keep working on it, and try to pass the information to the AR app. 


