# Unoti
Simple Notification Library for Unity games.

# How to install:
1. Download the mod file.
2. Place the `.dll` file in the appropriate plugins folder based on your installation:

   - **Steam Directory**:
     ```
     C:\Program Files (x86)\Steam\steamapps\common\GAME-NAME\BepInEx\plugins
     ```

   - **Oculus Directory**:
     ```
     C:\Program Files\Oculus\Software\Software\GAME-NAME\Gorilla Tag_Data\Plugins
     ```

# How to use:
Add "PC Notifications.dll" as an assembly reference to your project.

Put "using Notifications;" at the top of the project.

To send a notification, use "PCNotiLib.SendNotification("TEXT", "More text");" the notification will apear like this | [TEXT] More text

To clear all notifications use PCNotiLib.Clear()
