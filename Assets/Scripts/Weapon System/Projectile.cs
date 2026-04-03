using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D projectileRigidbody;
    [SerializeField] private float projectileSpeed;

    void Start()
    {
        projectileRigidbody.linearVelocity = transform.up * projectileSpeed;
    }
    

    void OnCollisionEnter2D( Collision2D collision )
    {
        Destroy(gameObject);
    }
}
