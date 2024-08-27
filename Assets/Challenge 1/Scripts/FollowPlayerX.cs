using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset = new(30f, 0f, 10f);

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
