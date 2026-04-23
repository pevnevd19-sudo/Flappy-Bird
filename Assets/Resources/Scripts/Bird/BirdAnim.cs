using UnityEngine;

public class BirdAnim : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D birdRigidbody;

    public void FlyAnimStart()
    {
        animator.SetFloat("BirdAnim", birdRigidbody.linearVelocity.y);
        
    }
}
