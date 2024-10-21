using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using static Notifications.PCNotiLib;

namespace Notifications.NotificationStuff
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerLeftRoom")]
    internal class LeavePatch : MonoBehaviour
    {
        private static void Prefix(Player otherPlayer)
        {
            if (otherPlayer != PhotonNetwork.LocalPlayer && otherPlayer != a)
            {
                SendNotification("<color=red>LEAVE</color>", $"{otherPlayer.NickName} Left the lobby.");
                a = otherPlayer;
            }
        }

        private static Player a;
    }
}