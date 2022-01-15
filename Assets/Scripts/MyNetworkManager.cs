using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.1.15
/// </summary>

public class MyNetworkManager : NetworkManager
{
    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);

        Debug.Log("servering and connecting to server..");
    }

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);

        Debug.Log($"there are now {numPlayers} players!");
    }
}
