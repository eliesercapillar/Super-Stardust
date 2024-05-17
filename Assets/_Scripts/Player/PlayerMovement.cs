using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerInput _playerInput;

        private void Awake()
        {
            _playerInput = new PlayerInput();
        }

        private void OnEnable()
        {
            _playerInput.Enable();
        }

        private void OnDisable()
        {
            _playerInput.Disable();
        }

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            Debug.Log("Im schmoovin!");

        }

        public void OnMovementSpecial()
        {
            Debug.Log("Im special");
        }
    }
}
