using UnityEngine;



public class Pickup : MonoBehaviour
{
    [SerializeField] private AudioClip pickUpSound;

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

        FindAnyObjectByType<AudioManager>().PlayPickUpSound(pickUpSound);
        Destroy(gameObject);
    }
}
