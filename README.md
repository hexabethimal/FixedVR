# FixedVR
VR motion controller for movement-in-place

This GitHub repository includes:
- a downloadable [installer](https://github.com/hexabethimal/FixedVR/releases) for FixedVR 
- project files for developers, including detailed comments for customization
- an Arduino sketch file
- a parts list with detailed instructions and alternatives
- a step-by-step setup guide for those new to Arduino and/or SteamVR

## Table of Contents
- [What is FixedVR?](https://github.com/hexabethimal/FixedVR#what-is-fixedvr)
- [Parts Required](https://github.com/hexabethimal/FixedVR#parts-required)
- [Setup](https://github.com/hexabethimal/FixedVR#arduino-setup)
  - [Arduino](https://github.com/hexabethimal/FixedVR#arduino-setup)
  - [FixedVR](https://github.com/hexabethimal/FixedVR#fixedvr-setup)
  - [Steam](https://github.com/hexabethimal/FixedVR#steam-setup)
- [Game Specific Setup](https://github.com/hexabethimal/FixedVR#game-specific-setup)
- [Compatibility Considerations](https://github.com/hexabethimal/FixedVR#compatibility-considerations)

## What is FixedVR?
This is a VR motion controller for forward movement in games, while walking or running in-place in real life. FixedVR does not require a movement harness or a large play area and is designed for both able-bodied individuals and those with disabilities or limited mobility.

With FixedVR, movement-in-place is combined with the ability to navigate corners or obstacles, bend down, sidestep, turn around in place without moving, and stop when desired. It is compatible with games running through SteamVR that support continuous movement; also known as smooth locomotion (not teleportation-only movement). 

As human movement varies based on individual differences, FixedVR provides multiple settings to adapt movement response to user preferences. Mouse-over tooltips provide extra information to help you make meaningful determinations about settings choices. Movement settings can be changed in-game as frequently as needed, without requiring restart. A debug panel is additionally available for those troubleshooting movement while making code adjustments.

![Image of FixedVR UI](/Images/interface7.png)

FixedVR functions as an XInput device translating controls to gamepad inputs in SteamVR control settings. It uses the [ScpVBus virtual gamepad driver](https://github.com/DavidRieman/ScpDriverInterface/) that is installed automatically when FixedVR is launched. Installation of the virtual driver is required.

FixedVR has had limited compatibility testing as of March 2023. Only the following are known to be compatible:
- HP Reverb G2 (version 2) with original hand controllers
- Half-Life: Alyx
- Half-Life 2: VR Mod
- Blade & Sorcery

Movement is handled the following way:
- As you walk-in-place, you will move at a walking pace in the game.
- After a set number of walking steps (configurable), your walking will automatically becoming running. This is both to simplify movement and to spare the user of actually running the distances required in many games.
- Jumping is not handled by FixedVR currently and this is intentional. Jumping in place while wearing a headset and no harness could be dangerous. It is even more dangerous to simulate forward jumping over a gap. Instead, jumping is mapped to the left joystick button which functions as a teleport.
- The SteamVR Controller Bindings setup explained below assumes player preference for weapons in the right-hand. Hand controller and gamepad controller bindings will have to be reversed for left-handed players.
- While walking and turning in real life is the immersive experience gained by using FixedVR, players can still additionally control turning on the left joystick and movement on the right joystick. (Using the joysticks for continuous turning or movement while remaining physically stationary might cause motion sickness.)

## Parts Required
Minimally, you will need an Arduino with WiFi capability and an accelerometer. Whether you choose to get these as a combination of board and shields, instead of an all-inclusive board is up to you. However, if you don’t choose the Arduino listed below, take into consideration that the movement-control of FixedVR may require modifications to accommodate the behavior of an IMU other than the ST LSM6DSOX 6-axis IMU contained in the Arduino Nano RP2040 Connect. 

Additionally, you will need some type of battery and connector (if not micro USB). The Arduino Nano RP2040 Connect can support other battery power options apart from a USB battery pack, but these will require soldering. Also, keep in mind that ordinary USB battery packs will automatically shut off at the low current requirements of the Arduino Nano RP2040 Connect.

You will also need something to hold the devices + power to each leg. I used a leg-band cell-phone holder with Velcro straps. If you have 2 legs, remember to buy 1 of each item for each leg. FixedVR also includes an option for movement activation on a single leg, whether for user preference or for disabled gamers. 

### Parts List (~$100 total) – No soldering required:
- Arduino Nano RP2040 Connect (per leg)
- [Low Current Lithium Ion Battery Pack 2.5Ah (USB)](https://www.sparkfun.com/products/15204) (per leg)
- Some kind of device holder (per leg)

## Setup
Setup will require 3 main types: Arduino setup, FixedVR setup, and SteamVR setup.

### Arduino Setup
1. Install the [Arduino IDE]( https://www.arduino.cc/en/software) from https://www.arduino.cc/en/software
2. Select the Arduino board you are using from the Tools menu
3. Update the relevant libraries to the latest version through Tools > Manage Libraries…
- For the Nano RP2040 Connect:
  - Arduino_LSM6DSOX
  - WiFiNINA
4. Modify the FixedVR.ino file with the following:
```
char ssid[] = “your_wifi_name”;
char pass[] = “your_wifi_password”;
IPAddress remoteHost(123,456,789,101); //The IP address of the computer running FixedVR
uint16_t portNumber = 12345; //The port number of the computer running FixedVR
```
5. Connect your Arduino to your computer, specify the COM Port under Tools, and Upload FixedVR.ino to your device . You can find the COM Port of the connected Arduino by going to Device Manager and looking under Ports (COM & LPT).

### FixedVR Setup
1. Run FixedVR and specify which open port to use for the connection. This must match the `uint16_t portNumber` in the Arduino.
2. Modify any settings as desired, then click Start Receiving when ready to run the program.

### Steam Setup
1. Use a text editor to view the SteamVR settings file located by default at the location below. Change `"activateMultipleDrivers"` from `false` to `true`. Save the file and exit. (This file may update during Steam updates restoring it to default values.)
```
C:\Program Files (x86)\Steam\steampps\common\SteamVR\resources\settings\default.vrsettings
```

### Game Specific Setup
The SteamVR Controller Bindings settings menus are difficult to navigate, difficult to understand, and at times unresponsive (sometimes requiring SteamVR restart). This is made even more difficult by only being able to make changes inside menus with your VR hand controllers and headset on. This step will therefore require you to either memorize the following screenshots, or to raise and lower your headset repeatedly while you refer back to these directions. It is tedious and frustrating, but you can save your controller profile and won’t have to do this again.

For each game, the only controller settings that absolutely need to be changed are the **Gamepad** settings. However, additional control settings provided will help compliment your leg movement with controls that permit you to turn or maneuver in tight spaces more easily and to jump or teleport to jump (depending on the game).

1. Half-Life: Alyx

   - First access the **Settings** menu in SteamVR, then click **Controllers**, then click **Manage Controller Bindings**.
![Image of settings menu](/Images/con1edit.png)

   - Click to expand the list of games and select the game of your choice (Half-Life: Alyx in this example). Then click **Edit This Binding**.
![Image of game select](/Images/con8edit.png)

   - Verify that the **Current Controller** selected are the hand motion controllers (HP Motion Controller in this example), then click **Edit** under **Current Binding**.
![Image of controller menu](/Images/con4edit.png)

   - First select the **Move** tab at the top, then scroll down till you see options for the left and right thumbsticks. Edit the controls to match this image. When you are finished, you can optionally click **Save Personal Binding**. Do not click Replace Default Binding (it is difficult to undo this action).
![Image of controller menu](/Images/con9edit.png)

   - Click **Back** to return to the previous screen. Then select the **Gamepad** controller and click **Edit** under **Current Binding**.
![Image of controller menu](/Images/con6edit.png)

   - First select the **Move** tab at the top, then scroll down till you see options for the left thumbstick. Edit the controls to match this image.
![Image of controller menu](/Images/con7edit.png)

   - Lastly, use the Half-Life: Alyx in-game **Preferences** menu to select **Movement: Continuous**.

2. Half-Life 2: VR Mod

   - No recommended changes to default hand motion controllers.

   - Select the **Gamepad** controller and click **Edit** under **Current Binding**. Select the **On Foot** tab and set **Left Thumbstick** to **Use as DPAD** with the following:
![Image of controller menu](/Images/hl2con1.png)     
	 
3. Blade & Sorcery

   - Verify that the **Current Controller** selected are the hand motion controllers (HP Motion Controller in this example), then click **Edit** under **Current Binding**. The following just reverses the default joystick movement controls with turn on the left, as the instructions above. 

   - Left Hand
![Image of controller menu](/Images/bscon1.png) 

   - Right Hand
![Image of controller menu](/Images/bscon2.png) 
   
   - Select the **Gamepad** controller and click **Edit** under **Current Binding**.
![Image of controller menu](/Images/bscon3.png)

   - Recommended to set FixedVR Walk Sensitivity to 5

## Compatibility Considerations
Although it is possible to enable smooth locomotion within SteamVR for both SteamVR Home and various SteamVR games (through editing the default vrsettings file for Windows Mixed Reality), overriding the intended movement results in clipping issues, inability to ascend/descend platforms, and instability issues. Thus, expanding compatibility with smooth locomotion to environments that don't support it natively is unlikely to provide a desirable experience.