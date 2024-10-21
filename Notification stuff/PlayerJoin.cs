using HarmonyLib;
using Photon.Pun;
using static Notifications.PCNotiLib;
using Photon.Realtime;

namespace Notifications.NotificationStuff
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
    internal class PlayerJoin
    {
        private static void Prefix(Player newPlayer)
        {
            if (newPlayer != oldnewplayer)
            {
                SendNotification("<color=green>JOIN</color>", $"{newPlayer.NickName} Joined the lobby.");
                oldnewplayer = newPlayer;
            }
        }

        private static Player oldnewplayer;
    }
}
