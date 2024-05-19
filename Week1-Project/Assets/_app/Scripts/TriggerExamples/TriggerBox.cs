using System;
using UnityEngine;

namespace _app.Scripts.TriggerExamples
{
    public class TriggerBox : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            //can use an if to track enemy v player 
            Debug.Log(other.transform.name + " Entered Trigger");
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