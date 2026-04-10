using UnityEngine;

public class Player : Character, IDash
{
    [SerializeField] protected Vector2 faceDirection;
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform weaponTip;

    private Weapon currentWeaponEquipped;


    public override void Start()
    {
        base.Start();
        ChangeWeapon( new RangedWeapon( projectilePrefab, weaponTip ) );
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
        currentWeaponEquipped.Use();
    }

    public void ExecuteDash()
    {
        characterRigidbody.AddForce(moveDirection * moveSpeed * 2);
    }

    public void ChangeWeapon(Weapon newWeapon)
    {
        currentWeaponEquipped = newWeapon;
    }
}
