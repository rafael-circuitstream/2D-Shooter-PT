using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected Vector2 moveDirection;
    [SerializeField] protected float moveSpeed;

    [SerializeField] protected Rigidbody2D characterRigidbody;
    public HealthModule health;
    

    public virtual void Start()
    {
        health = new HealthModule(100);
        
    }


    public void Move()
    {
        characterRigidbody.AddForce(moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    public void Rotate(Vector3 direction)
    {
        transform.up = direction;
    }

    public virtual void Attack()
    {
        Debug.Log("ATTACKING!");
    }


}
