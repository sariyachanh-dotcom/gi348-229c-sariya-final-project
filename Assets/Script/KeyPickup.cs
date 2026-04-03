using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public KeyColor keyColor;
    public int amount = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys player = other.GetComponent<PlayerKeys>();

            if (player != null)
            {
                player.AddKey(keyColor, amount);
                Debug.Log("Picked " + keyColor + " key! Total: " + player.GetKeys(keyColor));

                Destroy(gameObject);
            }
        }
    }
}