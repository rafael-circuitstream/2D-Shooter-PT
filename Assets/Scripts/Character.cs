using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public Vector2 moveDirection;
    [SerializeField] private float moveSpeed;

    [SerializeField] private Rigidbody2D characterRigidbody;
    public HealthModule health;
    

    public virtual void Start()
    {
        health = new HealthModule(100);
    }


    public void Move()
    {
        characterRigidbody.AddForce(moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    public virtual void Attack()
    {
        Debug.Log("ATTACKING!");
    }

}
