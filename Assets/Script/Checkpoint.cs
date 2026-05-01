using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public float interactDistance = 3f;
    public GameObject promptUI;
    private Transform playerCamera;
    private PlayerRespawn player;

    private bool isLooking = false;

    void Start()
    {
        playerCamera = Camera.main.transform;
    }

    void Update()
    {
        Ray ray = new Ray(playerCamera.position, playerCamera.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            if (hit.transform == transform)
            {
                promptUI.SetActive(true); 

                if (!isLooking)
                {
                    Debug.Log("Press E to set checkpoint");
                    isLooking = true;
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (player == null)
                        player = FindFirstObjectByType<PlayerRespawn>();

                    player.SetCheckpoint(transform.position);
                    Debug.Log("Checkpoint saved!");
                }

                return;
            }
        }

       
        promptUI.SetActive(false);
        isLooking = false;
    }
}