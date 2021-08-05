using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace NeonRunnerRevival
{
    public class WavesManager : MonoBehaviour
    {
        private enum SpawnState 
        {
            Spawning,
            Waiting,
            Checking,
            Finished
        }

        [SerializeField] private Wave[] _waves;
        [SerializeField] private Transform[] _spawnpoints;
        [SerializeField] private float _timeBetweenWaves = 5f;
        [SerializeField] private float _waveCountdown;
        [SerializeField] private float _searchCountdown;

        private SpawnState _state = SpawnState.Checking;
        private GameObject _enemyHolder;
        private int _nextWave = 0;
        private void Start()
        {
            _waveCountdown = _timeBetweenWaves;
            _enemyHolder = GameObject.Find("EnemyHolder");
        }
        private void Update()
        {
                switch (_state)
                {
                    case SpawnState.Spawning:
                        break;
                    case SpawnState.Waiting:
                        if (AreThereEnemiesAlive())
                        {
                            return;
                        }
                        else
                        {
                            WaveCompleted();
                        }
                        break;
                    case SpawnState.Checking:
                        if(_nextWave == _waves.Length)
                        {
                            _state = SpawnState.Finished;
                        }
                        if(_waveCountdown <= 0)
                        {
                            StartCoroutine(SpawnWave(_waves[_nextWave]));
                        }
                        else 
                        { 
                            _waveCountdown -= Time.deltaTime; 
                        }
                        break;
                    case SpawnState.Finished:
                        Debug.Log($"Finished game after {_waves.Length} rounds");
                        break;
                    default:
                        break;
                }
        }

        private void WaveCompleted()
        {
            //Update UI
            _state = SpawnState.Checking;
            _waveCountdown = _timeBetweenWaves;
            _nextWave++;
        }

        private bool AreThereEnemiesAlive()
        {
            _searchCountdown -= Time.deltaTime;
            if(_searchCountdown <= 0)
            {
                _searchCountdown = 1f;
                EnemyMarker enemyMarker = _enemyHolder.GetComponentInChildren<EnemyMarker>();
                if (enemyMarker)
                {
                    return true;
                }
            }
            return false;
        }
        private IEnumerator SpawnWave(Wave wave)
        {   
            //Here play Sound
            _state = SpawnState.Spawning;
            for (int i = 0; i < wave.Count; i++)
            {
                SpawnEnemy(wave.EnemyPrefab,wave.Name);
                yield return new WaitForSeconds(1f / wave.Rate);
            }
            _state = SpawnState.Waiting;
            yield break;
        }
        private void SpawnEnemy(GameObject enemyPrefab, string waveName)
        {
            Transform spawnPoint = _spawnpoints[Random.Range(0, _spawnpoints.Length - 1)];
            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            enemy.transform.SetParent(_enemyHolder.transform);
            enemy.name = "Enemy in {waveName}";
        }

        [Serializable]
        public class Wave
        {
            public int Count;
            public float Rate;
            public GameObject EnemyPrefab;
            public string Name;
        }
    }
}
