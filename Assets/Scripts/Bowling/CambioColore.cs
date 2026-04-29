using UnityEngine;

public class CambioColore : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palla"))
        {
            Material otherMaterial = other.GetComponent<Renderer>().material;
            Color randomColor = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));
            otherMaterial.color = randomColor;
        }
    }
}
