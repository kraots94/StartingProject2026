using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    private Transform myTransform;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        startingPosition = myTransform.position;
        startingRotation = myTransform.rotation;
    }

    private void Update()
    {
        myTransform.position = startingPosition;
        if (ZanonPlayerManager.Instance.IsGyroEnabled())
        {
            var attitudeValue = ZanonPlayerManager.Instance.GetGyroAttitude();
            myTransform.rotation = Quaternion.Euler(90, 0, 0) * GyroToUnity(attitudeValue);
        }
        else
        {
            myTransform.rotation = startingRotation;
        }
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }

}
