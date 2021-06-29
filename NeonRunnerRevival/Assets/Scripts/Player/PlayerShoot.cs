using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts;
using UnityEngine.InputSystem;

namespace NeonRunnerRevival
{
    public class PlayerShoot : MonoBehaviour
    {
        private PlayerStats _playerStats;
        public GameObject BulletPrefab;
        public Transform FirePoint;
        
        private PlayerControls _controls;
        private bool _held = false;
        private float _attackTimer;

        private void Start() {
            _playerStats = GetComponent<PlayerStats>();
        }

        private void Update() {
            if(_attackTimer < _playerStats.FireRate){
                _attackTimer += Time.deltaTime;
            }
            if(_held){
                Shoot();
            }
        }


        private void OnEnable() {
            _controls = GetComponent<PlayerStats>().Controls;
            _controls.TreadmillControls.Shoot.performed += OnShoot;
            _controls.TreadmillControls.Shoot.Enable();
        }

        private void OnDisable() {
            _controls.TreadmillControls.Shoot.performed -= OnShoot;
            _controls.TreadmillControls.Shoot.Disable();
        }

        public void OnShoot(UnityEngine.InputSystem.InputAction.CallbackContext context){
            _held = !_held;
        }

        private void Shoot(){
            if(_attackTimer < _playerStats.FireRate){
                return;
            }
            Instantiate(BulletPrefab, FirePoint.position , transform.rotation);
            _attackTimer -= _attackTimer;
        }

    }
}
