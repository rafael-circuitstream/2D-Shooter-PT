using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Transform playerTransformReference;


    public override void Start()
    {
        base.Start();

        playerTransformReference = FindAnyObjectByType<Player>().transform;
    }

    public virtual void Update()
    {
        moveDirection = playerTransformReference.position - transform.position;
        moveDirection = moveDirection.normalized;

        transform.up = moveDirection;

        Move();
    }

}
