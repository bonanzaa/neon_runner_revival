using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts.ArenaScripts;

namespace NeonRunnerRevival
{
    public class PlayerProjectile : MonoBehaviour
    {
        public float Damage;
        [SerializeField]
        private float _bulletSpeed = 10f;
        private Rigidbody2D rb;
        
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * _bulletSpeed;
            Destroy(gameObject,2f);
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if(!other.gameObject.CompareTag("Player")){
                other.gameObject.GetComponent<EnemyLife>().TakeDamage(Damage);
                Destroy(this.gameObject);
            }
        }
    }
}
