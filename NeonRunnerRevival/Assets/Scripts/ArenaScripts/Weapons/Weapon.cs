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


        // debug for shotgun
        public float SpreadAngle;

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
            // if the gun still can't shoot - return
            if(_attackTimer < _fireRate){
                return;
            }
            if(CurrentAmmo > 0 || InfiniteAmmo){
                switch(weaponType){
                    case(WeaponType.BasicGun):
                    BasicGunShoot();
                    break;

                    case(WeaponType.TheHose):
                    TheHoseShoot();
                    break;

                    case(WeaponType.TheSpread):
                    TheSpreadShoot();
                    break;
                }
            }
        }

        private void BasicGunShoot(){
            // PLAY AUDIO FOR BASIC GUN HERE

            GameObject bullet = Instantiate(BulletPrefab,FirePoint.transform.position, transform.rotation * Quaternion.Euler(0,0, -90));
            bullet.GetComponent<PlayerProjectile>().Damage = Damage;

             _attackTimer -= _attackTimer;
        }

        private void TheHoseShoot(){
            // PLAY AUDIO FOR THE HOSE GUN HERE

            GameObject bullet = Instantiate(BulletPrefab,FirePoint.transform.position, transform.rotation * Quaternion.Euler(0,0, -90));
            bullet.GetComponent<PlayerProjectile>().Damage = Damage;

             _attackTimer -= _attackTimer;
            CurrentAmmo--;

            if(CurrentAmmo == 0){
                _playerShoot.SwitchWeapon(WeaponType.BasicGun);
            }
        }

        private void TheSpreadShoot(){
            // PLAY AUDIO FOR THE SPREAD GUN HERE

            float angle = -SpreadAngle/BulletsFired;
            float angleStep = SpreadAngle / (BulletsFired -1);
            for (int i = 0; i < BulletsFired; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab,FirePoint.transform.position, transform.rotation * Quaternion.Euler(0,0, angle - 90));
                angle += angleStep;
                bullet.GetComponent<PlayerProjectile>().Damage = Damage;

                CurrentAmmo--;
                
            }
            if(CurrentAmmo == 0){
                _playerShoot.SwitchWeapon(WeaponType.BasicGun);
            }

            _attackTimer -= _attackTimer;
        }
    }
    // using enum to tell the weapons apart
    // YES it's not scalable, but it's easy and convenient
        public enum WeaponType{
            BasicGun,
            TheSpread,
            TheHose
        }

}

