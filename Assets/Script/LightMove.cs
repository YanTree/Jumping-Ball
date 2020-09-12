using UnityEngine;

public class LightMove : MonoBehaviour
{
    public Transform Player;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = Player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothPosition;
    }
}
