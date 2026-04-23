using UnityEngine;

public class BirdJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rigidbody;
    BirdAnim birdAnim;

    void Start()
    {
        birdAnim = GetComponentInChildren<BirdAnim>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
        birdAnim.FlyAnimStart();
    }
    private void Jump()
    {
        rigidbody.linearVelocity = new Vector2 (rigidbody.linearVelocityX, jumpForce);
    }
}
