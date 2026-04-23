using UnityEngine;

public class ScoreSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] GameObject score;
    private void Update()
    {
        Vector2 spawnPos = new Vector2(spawnPoint.transform.position.x,spawnPoint.transform.position.y);
        Instantiate(score, spawnPos, Quaternion.identity);
    }
}
