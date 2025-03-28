# Unoti

A lightweight, easy-to-use notification library for Unity mods with [BepInEx.](https://github.com/BepInEx/BepInEx)

---

## 🔧 Installation

1. Download the `Unoti.dll` file.
2. Place the `.dll` file into your game's plugin directory depending on your installation:

### 🟩 Steam Installation
C:\Program Files (x86)\Steam\steamapps\common\GAME-NAME\BepInEx\plugins


### 🟦 Oculus Installation
C:\Program Files\Oculus\Software\Software\GAME-NAME\Gorilla Tag_Data\Plugins

---

## 📦 Usage

1. Add **Unoti.dll** as an assembly reference in your project.
2. At the top of your script, include the namespace:
   ```csharp
   using Unoti;
   ```
3. To send a notification
   ```csharp
   UnotiAPI.SendNotification("Title", "Message text");
   ```
   The notification will appear in this format: [Title] Message text

4. To clear all active notifications:
   ```csharp
   UnotiAPI.Clear();
   ```

5. (Optional) Customize notification settings: You can modify various display options using UnotiAPI.UnotiSettings. For example:
   ```csharp
   UnotiAPI.UnotiSettings.verticleSpacing = 100;
   UnotiAPI.UnotiSettings.NotiPosition = UnotiAPI.NotificationPosition.CenterTop;
   ```

---

## 🛠 Features
- Simple API: SendNotification() and Clear()
- Customizable via UnotiSettings
- Works with Steam and Oculus installs
- Easily extendable in your own Unity mods

---

## 🤝 Contributing
Pull requests, suggestions, and bug reports are welcome!
- Fork the repo
- Create a feature branch
- Submit a pull request
Feel free to open issues to discuss improvements or ideas.
