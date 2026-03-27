using UnityEngine;

public class ScaryJump : MonoBehaviour
{
    public float duration = 3f;

    void OnEnable()
    {
        CancelInvoke(); 
        Invoke(nameof(Hide), duration);
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }
}
