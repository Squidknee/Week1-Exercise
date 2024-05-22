using System;
using _app.Scripts.Managers;
using UnityEngine;

namespace _app.Scripts.TriggerExamples
{
    public class TriggerBox : MonoBehaviour
    {
        [SerializeField] 
        [Header("Int Example")]
        public int scoreAmount;

        public Material triggeredMaterial;
        private Renderer boxRenderer;

        private void Start()
        {
            boxRenderer = GetComponent<Renderer>();
        }
        public void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player"))
            {
                if (AudioManager.instance !=null && GameManager.instance !=null)
                {
                    AudioManager.instance.PlayAudio();
                    GameManager.instance.ChangeScore(scoreAmount);
                    if (boxRenderer != null && triggeredMaterial != null)
                    {
                        boxRenderer.material = triggeredMaterial;
                    }
                    Destroy(this);
                }
                else
                {
                    //can use an if to track enemy v player
                    Debug.Log(other.transform.name + " Entered Trigger, no AudioManager");
                }
            }
            
        }

        public void OnTriggerExit(Collider other)
        {
            Debug.Log(other.transform.name + " Exited Trigger");
        }

        public void OnCollisionEnter(Collision other)
        {
            Debug.Log(other.transform.name + " Collided with object");
        }

        public void OnCollisionExit(Collision other)
        {
            Debug.Log(other.transform.name + " No longer colliding with object");
        }
    }
}