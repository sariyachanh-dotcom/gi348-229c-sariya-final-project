using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 checkpointPosition;

    void Start()
    {
        checkpointPosition = transform.position; 
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        checkpointPosition = newCheckpoint;
        Debug.Log("Checkpoint saved!");
    }

    public void Respawn()
    {
        transform.position = checkpointPosition;
        Debug.Log("Respawned at checkpoint");
    }
}