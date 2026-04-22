using UnityEngine;

public class Player : Character, IDash
{
    [SerializeField] protected Vector2 faceDirection;
    //[SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform weaponTip;

    [SerializeField] private Weapon currentWeaponEquipped;


    public override void Start()
    {
        base.Start();

        //ChangeWeapon( new RangedWeapon( projectilePrefab, weaponTip ) );

        health.OnHealthZero += GameOver;
    }

    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        faceDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        Rotate(faceDirection);

        Move();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ExecuteDash();
        }

        if (Input.GetMouseButtonDown (0) )
        {
            Attack();
        }
    }

    public override void Attack()
    {
        base.Attack();
        currentWeaponEquipped.Use(weaponTip);
    }

    public void ExecuteDash()
    {
        characterRigidbody.AddForce(moveDirection * moveSpeed * 2);
    }

    public void ChangeWeapon(Weapon newWeapon)
    {
        currentWeaponEquipped = newWeapon;
    }

    private void GameOver()
    {
        if(gameObject.activeInHierarchy)
        {
            FindAnyObjectByType<GameManager>().RegisterHighscore();
            gameObject.SetActive(false);
        }

    }
}
