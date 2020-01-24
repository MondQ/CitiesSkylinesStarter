# CitiesSkylinesStarter

After Paradox released an update to Cities Skylines in January 2020 and added a launcher I was unable to use Remote Play (In-home streaming) to play the game. All I would see is a black screen.

My solution was to write a program that is started via Steam, and then in turn starts Cities Skylines by clicking on the 'Play' button.
Just follow the instructions below to make sure the program clicks in the correct place.

# How to set up the Cities Skylines Starter

1. Download the program from here (or just find the ZIP file in the repo): https://github.com/MondQ/CitiesSkylinesStarter/blob/master/CitiesSkylinesStarter.zip
2. Place the folder containing CitiesSkylinesStarter on the computer you will be streaming Cities Skylines from
3. Open Steam
4. Click "Add a game"
5. Click "Add a non-Steam game"
6. Click "Browse..."
7. Select CitiesSkylinesStart.exe
8. Find CitiesSkylinesStart, right click it, click "Properties", click "Set launch options"
9. This is important!: You will need to set 3 parameters and can also set 2 optional parameters

  [1] Your screen's horizontal resolution e.g. 1920
  
  [2] Your screen's vertical resolution e.g. 1080
  
  [3] The path to Cities.exe e.g. C:\Program Files (x86)\Steam\steamapps\common\Cities_Skylines\Cities.exe
  
  [4] (Optional) Horizontal offset. By default the program will click at 50% of your screen's width and 40% from the top of the screen.   This should get you pretty close to the 'Play' button by default, but if it's not quite there you can use the X and Y offset to adjust    where the click goes. You can use positive and negative numbers
  
  [5] (Optional) Vertical offset. By default the program will click at 50% of your screen's width and 40% from the top of the screen.     This should get you pretty close to the 'Play' button by default, but if it's not quite there you can use the X and Y offset to adjust    where the click goes. You can use positive and negative numbers
  
  Example launch options: 1920 1080 "C:\Program Files (x86)\Steam\steamapps\common\Cities_Skylines" 10 0
  
  10. Stream CitiesSkylinesStarter to another device
  
  PS: At some point my anti-virus software (Avira free) flagged the program as a virus, which it is not. You can check out the source     code for yourself
  
  
  
  
  Credit for WindowsInput/InputSimulator goes to Michael Noonan

