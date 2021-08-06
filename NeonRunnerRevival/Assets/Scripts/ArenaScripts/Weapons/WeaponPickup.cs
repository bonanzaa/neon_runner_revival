using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace NeonRunnerRevival
{
    public class WeaponPickup : MonoBehaviour
    {
        public Sprite TheHose;
        public Sprite TheSpread;
        private Sprite _sprite;
        public WeaponType weaponType;
        public bool RandomWeapon;

        private void Awake() {
            if(RandomWeapon){
                weaponType = (WeaponType)UnityEngine.Random.Range(1, Enum.GetValues(typeof(WeaponType)).Length);
            }
            switch(weaponType){

                case(WeaponType.TheHose):
                _sprite = TheHose;
                break;

                case(WeaponType.TheSpread):
                _sprite = TheSpread;
                break;
            }
            GetComponent<SpriteRenderer>().sprite = _sprite;
        }

        private void OnTriggerEnter2D(Collider2D other) {
            if(other.CompareTag("Player")){
                other.GetComponent<PlayerShoot>().SwitchWeapon(weaponType);
                Destroy(this.gameObject);
            }
        }
    }
}
