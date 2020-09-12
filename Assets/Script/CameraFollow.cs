using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    public float smoothSpeed = 0.125f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 diresedPosition = Player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, diresedPosition, smoothSpeed);

        transform.position = smoothPosition;
    }
}
