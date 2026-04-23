using System.Collections;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<BirdMovement>();
        Debug.Log("1");
    }

    IEnumerator StopGame()
    {
        yield return null;
    }
}
