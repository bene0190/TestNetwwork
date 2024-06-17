using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefabs;
    public Transform spawnPoint;

    PlayerFollow playerFollow;
    private void Awake()
    {
        playerFollow = FindAnyObjectByType<PlayerFollow>();
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        //TODO: SpawnPlayers 
        GameObject player = PhotonNetwork.Instantiate(playerPrefabs.name, spawnPoint.position, spawnPoint.rotation);
        playerFollow.SetCameraTarget(player.transform);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
