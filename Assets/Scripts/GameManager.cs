using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player playerCharacter;

    private Weapon sword;
    private Weapon rifle;

    void Start()
    {
        playerCharacter = FindAnyObjectByType<Player>();

        sword = new MeleeWeapon();
        rifle = new RangedWeapon();

        playerCharacter.ChangeWeapon(sword);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerCharacter.ChangeWeapon(sword);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerCharacter.ChangeWeapon(rifle);
        }
    }

}
