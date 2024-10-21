# PC-Notification-Lib
Simple GTAG Notification lib by Lars remake for PC

# How to install:
Put "PCNotifications.dll" in the "plugins" folder in the BepInEx folder.

# How to use:
Add "PCNotifications.dll" as an assembly reference to your project.
Put "using PCNotifications;" at the top of the project.
To send a notification, use "PCNotiLib.SendNotification("TEXT", "More text");" the notification will apear like this | [TEXT] More text
To clear all notifications use PCNotiLib.Clear()
