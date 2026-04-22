using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Player playerReference;


    public override void Start()
    {
        base.Start();
        health.OnHealthZero += ReactToDeath;

        playerReference = FindAnyObjectByType<Player>();
    }

    public virtual void Update()
    {
        if(playerReference == null)
        {
            return;
        }

        moveDirection = playerReference.transform.position - transform.position;
        moveDirection = moveDirection.normalized;

        Rotate(moveDirection);

        Move();

        if(Vector2.Distance(transform.position, playerReference.transform.position) < 2)
        {
            Attack();
        }

    }

    public override void Attack()
    {
        if(playerReference.gameObject.activeInHierarchy)
        {
            playerReference.health.DecreaseHealth(Time.deltaTime);
        }

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
