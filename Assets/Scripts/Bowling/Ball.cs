using UnityEngine;

namespace Bowling
{
    public class Ball : MonoBehaviour
    {
        void FixedUpdate()
        {
            if(transform.position.y < -10f)
            {
                GameManager.Instance.SetGameState(GameManager.GameState.GameOver);
                Destroy(gameObject);
            }
        }

        void OnTriggerEnter(Collider other)
        {
        }

        void OnTriggerStay(Collider other)
        {
            
        }

        void OnTriggerExit(Collider other)
        {
            
        }
    }
}