using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Movement
{
    class PlayerMovement : MonoBehaviour
    {       
        private PlayerControls _controls;

        private Vector3 _rawMovementInput = new Vector3(0, 0, 0);
        
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.position += _rawMovementInput * _speed * Time.deltaTime;
        }

        private void OnEnable()
        {
            _controls = new PlayerControls();
            _controls.TreadmillControls.Movement.performed += OnMovement;
            _controls.TreadmillControls.Movement.Enable();
        }
        private void OnDisable()
        {
            _controls.TreadmillControls.Movement.performed -= OnMovement;
            _controls.TreadmillControls.Movement.Disable();
        }

        public void OnMovement(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            Vector2 movementInput = context.ReadValue<Vector2>();
            _rawMovementInput = new Vector3(movementInput.x, movementInput.y);            
            Debug.Log($"movemtn detected in {_rawMovementInput} direction");
        }
    }
}
