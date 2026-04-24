using UnityEngine;

namespace Bowling
{
    [RequireComponent(typeof(Rigidbody))]
    public class Birillo : MonoBehaviour
    {
        private bool hitted;
        private Vector3 startingPosition;
        private Quaternion startingRotation;
        [SerializeField] private AudioClip audioClip;

        void Start()
        {
            hitted = false;
            startingPosition = transform.position;
            startingRotation = transform.rotation;
        }

        void OnCollisionEnter(Collision collision)
        {
            if (hitted) return;
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            if (collision.gameObject.CompareTag("Ball"))
            {
                hitted = true;
                GameManager.Instance.BirilloHitted();
            }
        }

        public void ResetBirillo()
        {
            hitted = false;
            transform.position = startingPosition;
            transform.rotation = startingRotation;
        }
    }
}