using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class PlayerProjectile : MonoBehaviour
    {
        [SerializeField]
        private float _bulletSpeed = 10f;
        private Rigidbody2D rb;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            //GameObject player = GameObject.FindGameObjectWithTag("Player");
            rb.velocity = transform.up * _bulletSpeed;
            Destroy(gameObject,2f);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
