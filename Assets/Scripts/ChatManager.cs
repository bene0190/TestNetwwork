using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;

public class ChatManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject Message;
    public GameObject Content;
    public void SendMessage()
    {
        string message = inputField.text;
        GetComponent<PhotonView>().RPC("GetMessage",RpcTarget.All, (PhotonNetwork.NickName + " : "+ message));
    }

    [PunRPC]
    public void GetMessage(string ReceiveMessage)
    {
        GameObject M = Instantiate(Message,Vector3.zero,Quaternion.identity, Content.transform);
        M.GetComponent<PhotonChatManager>().MyMessage.text = ReceiveMessage;
    }
}
