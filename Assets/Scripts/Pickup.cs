using UnityEngine;



public class Pickup : MonoBehaviour
{
    [SerializeField] private AudioSource pickUpSound;

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
        pickUpSound.transform.SetParent(null);

        pickUpSound.Play();
        Destroy(gameObject);
    }
}
