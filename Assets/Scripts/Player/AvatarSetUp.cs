using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AvatarSetUp : MonoBehaviour
{
    PhotonView myPV;
    public GameObject[] hairStyle;
    public int hairIndex;
    public int CurrentHairIndex
    {
        get { return hairIndex; }
        set
        {
            if (value >= 0 && value < hairStyle.Length)
            {
                hairIndex = value;
                HairUpdater();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hairIndex = hairStyle.Length;
        CurrentHairIndex = PlayerData.instance.data.playerHat;
        for (int i = 0; i < hairStyle.Length; i++)
        {
            hairStyle[i].SetActive(i == hairIndex);
        } 
    }
    private void Update()
    {
        //CurrentHairIndex = hairIndex;
    }
    public void HairUpdater()
    {
        for (int i = 0; i < hairStyle.Length; i++)
        {
            hairStyle[i].SetActive(i == hairIndex);
        }
    }

    public void SetAvatar(Data avatarData)
    {
        hairStyle[avatarData.playerHat].SetActive(true);
    }
}
