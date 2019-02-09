using UnityEngine;

public class WallDestruction : MonoBehaviour
{
    public Rigidbody rb;

    private void OnMouseDown()
    {
        // gameObject.SetActive(false);
        Debug.Log("On Mouse Down Wall destruction,");
        rb.useGravity = !rb.useGravity;
        if (!rb.useGravity) {
            rb.velocity = Vector3.zero;
        }
    }
}
