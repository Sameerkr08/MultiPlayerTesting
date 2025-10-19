using UnityEngine;
using Photon.Pun;

public class UiManager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject  _player, _enemy;
    GameObject _cube;

    private void Start()
    {
        PhotonNetwork.Instantiate(_player.name, _player.transform.position, Quaternion.identity);
        if (PhotonNetwork.LocalPlayer == PhotonNetwork.MasterClient)
        {
            PhotonNetwork.InstantiateRoomObject(_enemy.name, _enemy.transform.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            PhotonNetwork.Instantiate(_cube.name, _cube.transform.position, Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameObject r = PhotonNetwork.InstantiateRoomObject(_cube.name, _cube.transform.position, Quaternion.identity);
            r.transform.position = new Vector3(2f, 2f, 2f);
        } */


    }

}