using UnityEditor.Rendering;
using UnityEngine;

public class SpawnerTrigger : MonoBehaviour
{
    [SerializeField]private BackGroundSpawner backGroundSpawner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BirdMovement>() != null) backGroundSpawner.BackGroundSpawn(1);
    }
}
