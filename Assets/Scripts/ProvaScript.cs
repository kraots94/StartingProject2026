using UnityEngine;

public class ProvaScript : MonoBehaviour
{
    Transform myTransform;
    float speed = 5;
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }
    void Update()
    {
        myTransform.Translate(Vector3.right * speed);
    }
}