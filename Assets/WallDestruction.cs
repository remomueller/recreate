using UnityEngine;

public class WallDestruction : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        Debug.Log("On Mouse Down Wall destruction,");
    }
}
