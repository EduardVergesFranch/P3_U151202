# P3: Developing a Interactive System with PosNet and OSC
## UPF Interactive Systems Course 2019/2020

#### INTRODUCTION
The aim of this Unity project is to build our first interactive experience using PosNet technology and OSC protocol. In my case, I have developed an Aquarium that has two types of fihes and your are able to interact with them in different ways.
This fishes and their behaviour will be used for the final project of the course with some modifications to obtain a more realistic result.

You need to run this project in Unity. I have used version *2019.3.7f1*.
#### SCENE CONTEXT
You are in front of an Aquarium where the fishes are scared of being seen. You have to be quiet and crouch and the fishes will appear. There are manily two types of fhishes: the **big and yellow** one that will follow your motion and the **little and white** one that, when you touch it with your wrists, will speed up.
#### SCREEN VIEW
In the screen, you will see one **red cube**, that **represents the current position of your nose**, and **two purple cubes**, that **represent the position of your left and right wirsts**.
#### FEATURES ADDED
  1. When the *y position* of your noise is less than *-150*, the fishes will start to appear. There are two possible spawns: **Big          Yellow Fish** and **Little White Fish**.
  2. When the big yellow fish spawns, it will follow the motion of your nose.
  3. When the little white fish spawns, it will move randomly around the aquarium. If you touch it with your wrists, it will speed up.

#### RESOURCES USED
PoseNet to OSC adaptation
https://github.com/tommymitch/posenetosc 

extOSC unity package
https://assetstore.unity.com/packages/tools/input-management/extosc-open-sound-control-72005

Follow the instructions to run PoseNet OSC and then run the Unity project
