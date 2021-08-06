using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class Weapon : MonoBehaviour
    {
        public WeaponType weaponType;
        public float AttackSpeed;
        public int Damage;
        public int BulletsFired;
        public int CurrentAmmo;
        public int MaxAmmo;
        public bool InfiniteAmmo;
        public GameObject BulletPrefab;
        public Transform FirePoint;

        private PlayerShoot _playerShoot;

        private float _attackTimer;
        private float _fireRate;
        private static int _maxAmmo;

        private void OnEnable() {
            _fireRate = 1 / AttackSpeed;
            ResetAmmo();
        }


        private void Start() {
            _playerShoot = transform.parent.GetComponent<PlayerShoot>();
        }

        private void Update() {
            if(_attackTimer < _fireRate){
                _attackTimer += Time.fixedDeltaTime;
            }
        }

        public void ResetAmmo(){
            CurrentAmmo = MaxAmmo;
        }

        public void OnShoot(){
            if(_attackTimer < _fireRate){
                return;
            }
            if(!InfiniteAmmo && CurrentAmmo > 0){

                GameObject bullet = Instantiate(BulletPrefab,FirePoint.transform.position, transform.rotation * Quaternion.Euler(0,0, -90));
                bullet.GetComponent<PlayerProjectile>().Damage = Damage;

                _attackTimer -= _attackTimer;
                CurrentAmmo--;

                if(CurrentAmmo == 0){
                    // switch the weapon back to the basic gun
                    _playerShoot.SwitchWeapon(WeaponType.BasicGun);
                }
            }else if(InfiniteAmmo){
                GameObject bullet = Instantiate(BulletPrefab,FirePoint.transform.position, transform.rotation * Quaternion.Euler(0,0, -90));
                bullet.GetComponent<PlayerProjectile>().Damage = Damage;

                _attackTimer -= _attackTimer;
            }
        }
    }
        public enum WeaponType{
            BasicGun,
            TheSpread,
            TheHose
        }

}

