using UnityEngine;

public class Player : Character, IDash
{
    [SerializeField] private Vector2 faceDirection;

    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        faceDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.up = faceDirection;

        //attack when clicking the mouse

        Move();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ExecuteDash();
        }
    }


    public void ExecuteDash()
    {
        characterRigidbody.AddForce(moveDirection * moveSpeed * 2);
    }

}
