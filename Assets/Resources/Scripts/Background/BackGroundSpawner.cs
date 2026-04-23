using System.Collections.Generic;
using UnityEngine;

public class BackGroundSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cloudss;
    private List<GameObject> clouds;
    private float currentSpawnPoint;
    [SerializeField]private SpawnerTrigger setSpawn;

    private void Start()
    {
        currentSpawnPoint = transform.position.x;
        clouds = new List<GameObject>();
    }
    public void BackGroundSpawn(int count)
    {
        
    }

}
