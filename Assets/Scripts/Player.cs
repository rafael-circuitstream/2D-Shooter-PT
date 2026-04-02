using UnityEngine;

public class Player : Character
{
    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        //face the direction of our mouse cursor
        
        //attack when clicking the mouse

        Move();
    }
}
