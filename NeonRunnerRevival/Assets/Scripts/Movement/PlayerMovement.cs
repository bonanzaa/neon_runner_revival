using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Movement
{
    class PlayerMovement : MonoBehaviour
    {       
        private PlayerControls _controls;

        private float _speed;

        private void OnEnable()
        {
            _controls = new PlayerControls();
            _controls.Player.Up.performed += Up_performed;
        }
        private void OnDisable()
        {
            _controls.Player.Up.performed -= Up_performed;
        }

        private void Up_performed(UnityEngine.InputSystem.InputAction.CallbackContext Context)
        {
            Debug.Log("Up Pressed");
        }
    }
}
