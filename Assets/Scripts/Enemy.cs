using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Transform playerTransformReference;


    public override void Start()
    {
        base.Start();
        health.OnHealthZero += ReactToDeath;

        playerTransformReference = FindAnyObjectByType<Player>().transform;
    }

    public virtual void Update()
    {
        moveDirection = playerTransformReference.position - transform.position;
        moveDirection = moveDirection.normalized;

        Rotate(moveDirection);

        Move();
    }



    private void ReactToDeath()
    {
        FindAnyObjectByType<GameManager>().RemoveEnemyFromList(this);
        Destroy(gameObject);
        //play a sound
        //spawn effects
        //add score
    }

}
