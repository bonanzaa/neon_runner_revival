using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using NeonRunnerRevival.Assets.Scripts.Manager;

namespace NeonRunnerRevival.Assets.Scripts.ArenaScripts
{
    class EnemyLife : MonoBehaviour
    {
        [SerializeField] private float _health;
        [SerializeField] private bool _isCluster;
        private bool _isCollidingWithPlayer = false;

        private float _explosionRange = 3f;
        public void TakeDamage(float damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                Die();
            }
        }

        private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.CompareTag("Player")){
                other.gameObject.GetComponent<PlayerStats>().TakeDamage(1);
                _isCollidingWithPlayer = true;
                StartCoroutine(DealPeriodicDamageToPlayerWhileColliding());
            }
        }

        private void OnCollisionExit2D(Collision2D other) {
            _isCollidingWithPlayer = false;
        }

        private IEnumerator DealPeriodicDamageToPlayerWhileColliding(){
            PlayerStats playerStats = PlayerTracker.Instance.Player.GetComponent<PlayerStats>();
            while(_isCollidingWithPlayer){
                yield return new WaitForSeconds(1);
                playerStats.TakeDamage(1);
            }
            yield break;
        }

        private void Die()
        {
            LootDrop loot = PlayerTracker.Instance.GetComponent<LootDrop>();
            Vector3 pos = transform.position;
            GameObject lootDropped = loot.CalculateLoot();
            if(lootDropped != null){
                Instantiate(lootDropped, pos, Quaternion.identity);
            }
            if (_isCluster)
            {
                Explode();
            }
            else
            {
                Destroy(gameObject);
            }
        }
        //copied from neon runner
        private void Explode()
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, _explosionRange);

            foreach (var hit in hitColliders)
            {
                if(hit.TryGetComponent(out PlayerMarker playerMarker))
                {
                    //playerHealth, not marker, take damage or whatever it's called
                    //Debug.Log($"Hit {hit.name} boom boom change to Player Health");
                }
            }
            Destroy(gameObject);
        }

        [Button]
        public void TakeDamage()
        {
            _health -= 1;
            if (_health <= 0)
            {
                Die();
            }
        }

    }
}
