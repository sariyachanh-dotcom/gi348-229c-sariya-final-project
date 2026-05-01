using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject enemy;
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


                if (keyColor == KeyColor.Purple)
                {
                    enemy.SetActive(true);
                }

                Destroy(gameObject);
            }
        }
    }
}