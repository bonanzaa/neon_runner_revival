using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts;
using UnityEngine.InputSystem;

namespace NeonRunnerRevival
{
    public class PlayerShoot : MonoBehaviour
    {   
        public Weapon CurrentWeapon;

        public Weapon BasicGun;
        public Weapon TheSpread;
        public Weapon TheHose;


        private PlayerControls _controls;
        private bool _held = false;

        private void Update() {
            if(_held){
                CurrentWeapon.OnShoot();
            }
        }


        private void OnEnable() {
            _controls = new PlayerControls();
            //_controls = GetComponent<PlayerMovement>()._controls;
            _controls.TreadmillControls.Shoot.performed += OnShoot;
            _controls.TreadmillControls.Shoot.Enable();
            SwitchWeapon(WeaponType.TheSpread);
        }

        public void SwitchWeapon(WeaponType weaponType){
            if(CurrentWeapon != null && weaponType == CurrentWeapon.weaponType){
                CurrentWeapon.ResetAmmo();
                return;
            }
            switch(weaponType){
                case(WeaponType.BasicGun):
                CurrentWeapon = BasicGun;

                BasicGun.gameObject.SetActive(true);
                TheSpread.gameObject.SetActive(false);
                TheHose.gameObject.SetActive(false);
                break;

                case(WeaponType.TheSpread):
                CurrentWeapon = TheSpread;

                BasicGun.gameObject.SetActive(false);
                TheSpread.gameObject.SetActive(true);
                TheHose.gameObject.SetActive(false);
                break;

                case(WeaponType.TheHose):
                CurrentWeapon = TheHose;

                BasicGun.gameObject.SetActive(false);
                TheSpread.gameObject.SetActive(false);
                TheHose.gameObject.SetActive(true);
                break;
            }
        }

        private void OnDisable() {
            _controls.TreadmillControls.Shoot.performed -= OnShoot;
            _controls.TreadmillControls.Shoot.Disable();
        }

        public void OnShoot(UnityEngine.InputSystem.InputAction.CallbackContext context){
            _held = !_held;
        }

    }
}
