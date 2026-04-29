using System.Collections.Generic;
using UnityEngine;

public class AbilitaFuoco : MonoBehaviour
{
    [SerializeField] private List<GameObject> fuochi;

    private bool fuochiAbilitati;

    void Start()
    {
        DisabilitaFuochi();
    }

    void OnTriggerEnter(Collider other)
    {
        if(fuochiAbilitati == true) return;

        if (other.CompareTag("Palla"))
        {
            AbilitaFuochi();
        }
    }

    void OnTriggerStay(Collider other)
    {
        
        if(fuochiAbilitati == true) return;

        if (other.CompareTag("Palla"))
        {
            AbilitaFuochi();
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if(fuochiAbilitati == false) return;

        if (other.CompareTag("Palla"))
        {
            DisabilitaFuochi();
        }
    }

    private void AbilitaFuochi()
    {
        foreach(GameObject fuoco in fuochi)
        {
            fuoco.SetActive(true);
        }
        fuochiAbilitati = true;
    }
    
    private void DisabilitaFuochi()
    {
        foreach(GameObject fuoco in fuochi)
        {
            fuoco.SetActive(false);
        }
        fuochiAbilitati = false;
    }
}
