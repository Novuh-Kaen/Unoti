using UnityEngine;
using BepInEx;
using System.Collections.Generic;

namespace Notifications
{
    [BepInPlugin("Novuh.PCNotifications", "PC Notification Library", "1.0.2")]
    public class PCNotiLib : BaseUnityPlugin
    {
        private static List<string> notifications = new List<string>();
        private static float notificationDuration = 2.3f;
        private static float nextNotificationTime = 0;

        public static void SendNotification(string customThing, string notiText)
        {
            string skibidi = $"[ {customThing} ] {notiText}";

            if (notifications.Count > 0 && notifications[notifications.Count - 1] == skibidi)
            {
                return;
            }

            if (notifications.Count < 6)
            {
                notifications.Add(skibidi);
            }

            if (notifications.Count == 1)
            {
                nextNotificationTime = Time.time + notificationDuration;
            }
        }

        public static void Clear()
        {
            notifications.Clear();
        }

        void Update()
        {
            if (notifications.Count > 0 && Time.time >= nextNotificationTime)
            {
                notifications.RemoveAt(0);
                if (notifications.Count > 0)
                {
                    nextNotificationTime = Time.time + notificationDuration;
                }
            }
        }

        void OnGUI()
        {
            GUIStyle guistyle = new GUIStyle
            {
                fontSize = 17,
                normal = new GUIStyleState
                {
                    textColor = Color.white,
                    background = CreateBackgroundTexture(2, 2, new Color(0.05f, 0.05f, 0.05f, 0.8f))
                },
                padding = new RectOffset(10, 10, 5, 5)
            };

            GUILayout.BeginVertical();
            foreach (var notification in notifications)
            {
                GUILayout.Space(5);
                GUILayout.Label(notification, guistyle);
            }
            GUILayout.EndVertical();
        }

        private Texture2D CreateBackgroundTexture(int width, int height, Color color)
        {
            Texture2D texture = new Texture2D(width, height);
            Color[] pixels = new Color[width * height];

            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = color;
            }

            texture.SetPixels(pixels);
            texture.Apply();
            return texture;
        }
    }
}