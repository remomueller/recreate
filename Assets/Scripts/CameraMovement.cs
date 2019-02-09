using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public bool moveUp = false;
    public bool moveDown = false;
    public bool moveLeft = false;
    public bool moveRight = false;
    public float scrollSpeed = 10f;

    private void Update()
    {
        moveDown = Input.GetKey("s");
        moveUp = Input.GetKey("w");
        moveLeft = Input.GetKey("a");
        moveRight = Input.GetKey("d");
    }

    private void FixedUpdate()
    {
        if (moveDown)
        {
            transform.position += new Vector3(0, -scrollSpeed * Time.deltaTime, 0);
        }

        if (moveUp)
        {
            transform.position += new Vector3(0, scrollSpeed * Time.deltaTime, 0);
        }

        if (moveLeft)
        {
            transform.position += new Vector3(-scrollSpeed * Time.deltaTime, 0, 0);
        }

        if (moveRight)
        {
            transform.position += new Vector3(scrollSpeed * Time.deltaTime, 0, 0);
        }
    }
}
