using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class PlayerProjectile : MonoBehaviour
    {
        public int Damage;
        [SerializeField]
        private float _bulletSpeed = 10f;
        private Rigidbody2D rb;
        
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * _bulletSpeed;
            Destroy(gameObject,2f);
        }
    }
}
