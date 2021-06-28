using UnityEngine;
using System;
using System.Collections;

namespace NeonRunnerRevival.Assets.Scripts.Movement
{
    class PlayerMovement : MonoBehaviour
    {       
        private PlayerControls _controls;

        private Vector3 _rawMovementInput = new Vector3(0, 0, 0);
        
        [SerializeField] private float _speed;
        private Rigidbody2D rb;
        private bool _canDash = true;
        private bool _Dashing = false;
        private float _dashTime = 0.1f;
        public float DashCooldown = 1.5f;
        public float DashDistance = 50f;

        private void Start() {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }


        private void OnEnable()
        {
            _controls = new PlayerControls();
            _controls.TreadmillControls.Movement.performed += OnMovement;
            _controls.TreadmillControls.Movement.Enable();

            _controls.TreadmillControls.Dash.performed += OnDash;
            _controls.TreadmillControls.Dash.Enable();
        }
        private void OnDisable()
        {
            _controls.TreadmillControls.Movement.performed -= OnMovement;
            _controls.TreadmillControls.Movement.Disable();

            _controls.TreadmillControls.Dash.performed -= OnDash;
            _controls.TreadmillControls.Dash.Disable();
        }

        public void OnMovement(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            Vector2 movementInput = context.ReadValue<Vector2>();
            _rawMovementInput = new Vector3(movementInput.x, movementInput.y);            
            //Debug.Log($"movement detected in {_rawMovementInput} direction");
        }

        public void OnDash(UnityEngine.InputSystem.InputAction.CallbackContext context){
            if(_canDash && _Dashing == false){ 
                // takes the direction from the movement
                Dash(_rawMovementInput);
            }
        }
        private void Move()
        {
            transform.position += _rawMovementInput * _speed * Time.deltaTime;
        }

        private void Dash(Vector2 direction){
            _Dashing = true;
            // good place for enabling i-frames
            // and "levitation" or whatever
            StartCoroutine(Dashing(direction));
            StartCoroutine(DashCooldownTimer());
        }

        private IEnumerator DashCooldownTimer(){
            _canDash = false;
            float cooldown = DashCooldown;
            while(cooldown > 0){
                // cooldown could possibly be diplayed somewhere
                // on the screen
                cooldown -= Time.deltaTime;
                yield return new WaitForSeconds(Time.deltaTime);
            }
            _canDash = true;
            yield break;
        }

        // dashing through coroutine
        private IEnumerator Dashing(Vector2 direction){
            float time = _dashTime;
            while(time > 0){

                rb.velocity = direction * DashDistance;
                
                time -= Time.deltaTime;
                yield return new WaitForSeconds(Time.deltaTime);
            }
            rb.velocity = new Vector2(0,0);
            _Dashing = false;
            // disable i-frames here
            yield break;
        }

        private void SetSpeed(float value)
        {
            _speed = value;
        }

        private void AddSpeed(float value){
            _speed += value;
        }

        private void RemoveSpeed(float value){
            _speed -= value;
        }

        private void IncreasePercentSpeed(float percent){
            float additionalValue = percent * _speed / 100f;
            _speed += additionalValue;
        }

        private void DecreasePercentSpeed(float percent){
            float additionalValue = percent * _speed / 100f;
            _speed -= additionalValue;
        }
    }
}
