using UnityEngine;
using BepInEx;
using System.Collections.Generic;
using System;

namespace Notifications
{
    [BepInPlugin("Novuh.PCNotifications", "PC Notification Library", "1.0.0")]
    public class PCNotiLib : BaseUnityPlugin
    {
        private static List<string> notifications = new List<string>();
        private static float notificationDuration = 2.3f;
        private static float nextNotificationTime = 0;

        public static void SendNotification(string customThing, string notiText)
        {
            notifications.Add($"[ {customThing} ] {notiText}");

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

            if (notifications.Count > 10)
            {
                notifications.RemoveAt(0);
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
                    background = backgroundThing(2, 2, new Color(0.05f, 0.05f, 0.05f, 0.8f))
                },
                padding = new RectOffset(10, 10, 5, 5)
            };

            GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
            for (int i = 0; i < notifications.Count; i++)
            {
                float width = GUI.skin.label.CalcSize(new GUIContent(notifications[i])).x;
                GUILayout.Label(notifications[i], guistyle, Array.Empty<GUILayoutOption>());
            }
            GUILayout.EndVertical();
        }

        Texture2D backgroundThing(int width, int height, Color color)
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