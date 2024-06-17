using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected");
        SceneManager.LoadScene("Lobby");
    }

}
