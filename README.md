# PC-Notification-Lib
Simple GTAG Notification lib by Lars remake for PC originally made for my menu Kaen Pad

# How to install:
Put "PCNotifications.dll" in the "plugins" folder in the BepInEx folder.

# How to use:
Add "PC Notifications.dll" as an assembly reference to your project.

Put "using Notifications;" at the top of the project.

To send a notification, use "PCNotiLib.SendNotification("TEXT", "More text");" the notification will apear like this | [TEXT] More text

To clear all notifications use PCNotiLib.Clear()
