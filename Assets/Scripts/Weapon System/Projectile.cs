using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D projectileRigidbody;
    [SerializeField] private float projectileSpeed;

    public float damage;

    void Start()
    {
        projectileRigidbody.linearVelocity = transform.up * projectileSpeed;
        Destroy(gameObject, 6);
    }
    

    void OnCollisionEnter2D( Collision2D collision )
    {
        
        if(collision.gameObject.CompareTag("Enemy")  )
        {
            collision.gameObject.GetComponent<Enemy>().health.DecreaseHealth(damage);
        }
        
        Destroy(gameObject);
    }
}
