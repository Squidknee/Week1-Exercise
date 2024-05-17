using System;
using UnityEngine;

namespace _app.Scripts.Player
{
    public class CharacterController : MonoBehaviour
    {
        [Header("Movement Variables")] 
        public float movementSpeed;
        public Vector3 jumpForce;
        public bool crouching;

        [Header("Player Components")] 
        public Rigidbody rb;
        public Camera playerCamera;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerJump();
            }
        }

        private void PlayerJump()
        {
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }

        private void PlayerMovement()
        {
            transform.Translate(new Vector3(3,0,0));
        }
    }
}