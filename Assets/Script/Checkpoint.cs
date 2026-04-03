using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private bool playerInRange = false;
    private PlayerRespawn player;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (player != null)
            {
                player.SetCheckpoint(transform.position);

                if (DoorUI.instance != null)
                    DoorUI.instance.Show("Checkpoint saved!");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            player = other.GetComponent<PlayerRespawn>();

            if (DoorUI.instance != null)
                DoorUI.instance.Show("Press E to save checkpoint");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            player = null;

            if (DoorUI.instance != null)
                DoorUI.instance.Hide();
        }
    }
}