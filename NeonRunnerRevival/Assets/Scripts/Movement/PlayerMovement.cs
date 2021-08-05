using UnityEngine;
using System;
using System.Collections;
using NeonRunnerRevival.Assets.Scripts.Manager;

namespace NeonRunnerRevival.Assets.Scripts.Movement
{
    class PlayerMovement : MonoBehaviour
    {       
        private PlayerControls _controls;
        private Vector3 _rawMovementInput = new Vector3(0, 0, 0);
        
        [SerializeField] private float _speed;
        private Rigidbody2D rb;
        private PlayerStats _playerStats;
        private Camera _mainCamera;
        private Vector2 _mousePos;
        private bool _canDash = true;
        [NonSerialized]
        public bool Dashing = false;
        private float _dashTime = 0.1f;
        public float DashCooldown = 1.5f;
        public float DashDistance = 50f;

        private void Start() {
            rb = GetComponent<Rigidbody2D>();
            _playerStats = GetComponent<PlayerStats>();           
            _mainCamera = Camera.main;
        }

        private void Update() {
            MouseRotate();
        }

        private void FixedUpdate() {
            // doing this in FixedUpdate, because of collision
            // detection issues. In Update() it skips the collision
            // calculation frames, and the player jitters
            // when colliding with something
            Move();
        }


        private void OnEnable()
        {
            _controls = new PlayerControls();

            _controls.TreadmillControls.Movement.performed += OnMovement;
            _controls.TreadmillControls.Movement.Enable();

            _controls.TreadmillControls.Dash.performed += OnDash;
            _controls.TreadmillControls.Dash.Enable();

            _controls.TreadmillControls.MousePosition.performed += OnMousePosition;
            _controls.TreadmillControls.MousePosition.Enable();
        }
        private void OnDisable()
        {
            _controls.TreadmillControls.Movement.performed -= OnMovement;
            _controls.TreadmillControls.Movement.Disable();

            _controls.TreadmillControls.Dash.performed -= OnDash;
            _controls.TreadmillControls.Dash.Disable();

            _controls.TreadmillControls.MousePosition.performed -= OnMousePosition;
            _controls.TreadmillControls.MousePosition.Disable();
        }

        public void OnMovement(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            Vector2 movementInput = context.ReadValue<Vector2>();
            _rawMovementInput = new Vector3(movementInput.x, movementInput.y);            
            //Debug.Log($"movement detected in {_rawMovementInput} direction");
        }



        public void OnDash(UnityEngine.InputSystem.InputAction.CallbackContext context){
            if(_canDash && Dashing == false){ 
                // takes the direction from the movement
                Dash(_rawMovementInput);
            }
        }

        public void OnMousePosition(UnityEngine.InputSystem.InputAction.CallbackContext context){
            _mousePos = context.ReadValue<Vector2>();
        }
        private void Move()
        {
            transform.position += _rawMovementInput * _speed * Time.deltaTime;
        }

        private void MouseRotate(){
            
            Vector3 mouseWorldSpace = _mainCamera.ScreenToWorldPoint(_mousePos);

            Vector3 direction = mouseWorldSpace - transform.position;


            float angle = Mathf.Atan2(direction.y, direction.x); // in radians
            transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg - 90);

            //direction.z = 0;
        }

        private void Dash(Vector2 direction){
            Dashing = true;
            // good place for enabling i-frames
            // and "levitation" or whatever
            StartCoroutine(TheDash(direction));
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
        private IEnumerator TheDash(Vector2 direction){
            float time = _dashTime;
            while(time > 0){

                rb.velocity = direction * DashDistance;
                
                time -= Time.deltaTime;
                yield return new WaitForSeconds(Time.deltaTime);
            }
            rb.velocity = new Vector2(0,0);
            Dashing = false;
            // disable i-frames here
            yield break;
        }

        public void SetSpeed(float value)
        {
            _speed = value;
        }

        public void AddSpeed(float value){
            _speed += value;
        }

        public void RemoveSpeed(float value){
            _speed -= value;
        }

        public void IncreasePercentSpeed(float percent){
            float additionalValue = percent * _speed / 100f;
            _speed += additionalValue;
        }

        public void DecreasePercentSpeed(float percent){
            float additionalValue = percent * _speed / 100f;
            _speed -= additionalValue;
        }
    }
}
