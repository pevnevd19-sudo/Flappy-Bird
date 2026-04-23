using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int dirrection;
    [SerializeField] private Rigidbody2D rigibody;

    private void Start()
    {
        dirrection = 1;
        StartCoroutine(SpeedIncrement());
    }
    private void FixedUpdate()
    {
        rigibody.linearVelocityY = Mathf.Clamp(rigibody.linearVelocityY, -7, 4);
        dirrection = Mathf.Clamp(dirrection, -1, 1);
        rigibody.linearVelocity = new Vector2(speed * dirrection, rigibody.linearVelocityY);
    }
    private void Update()
    {
        
    }
    IEnumerator SpeedIncrement()
    {
        for (int i = 0; i < 100; i++)
        { 
            yield return new WaitForSeconds(10f);
            speed += 0.5f;
            Debug.Log("Speed UP");
        }
    }
}
