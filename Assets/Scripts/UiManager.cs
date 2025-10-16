using UnityEngine;
using Photon.Pun;

public class UiManager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject _clientCube;
    [SerializeField] GameObject _roomCube;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            PhotonNetwork.Instantiate(_clientCube.name, _clientCube.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PhotonNetwork.InstantiateRoomObject(_roomCube.name, _roomCube.transform.position, Quaternion.identity);
        }
    }
}
