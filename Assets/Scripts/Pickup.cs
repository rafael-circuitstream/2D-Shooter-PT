using UnityEngine;



public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.CompareTag("Player"))
        {
            Player temporaryPlayer = collision.attachedRigidbody.GetComponent<Player>();
            CollectPickup(temporaryPlayer);

        }
    }

    public virtual void CollectPickup(Player player)
    {
        //Play a sound
        //play particle effect
        Destroy(gameObject);
    }
}
