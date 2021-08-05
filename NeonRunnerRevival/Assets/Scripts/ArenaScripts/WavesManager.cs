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
        private bool _isSpawning;
        private int _nextWave = 0;
        private void Start()
        {
            _isSpawning = false;
            _waveCountdown = _timeBetweenWaves;
            _enemyHolder = GameObject.Find("EnemyHolder");
        }
        private void Update()
        {
                switch (_state)
                {
                    case SpawnState.Spawning:
                    if(!_isSpawning)
                            StartCoroutine(SpawnWave(_waves[_nextWave]));
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
                        if(_waveCountdown <= 0 && !AreThereEnemiesAlive())
                        {
                            _state = SpawnState.Spawning;
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
                //check here something's wrong
                EnemyMarker enemyMarker = _enemyHolder.GetComponentInChildren<EnemyMarker>();
                if (enemyMarker !=null)
                {
                    return true;
                }
            }
            return false;
        }
        private IEnumerator SpawnWave(Wave wave)
        {
            //Here play Sound
            _isSpawning = true;
            _state = SpawnState.Spawning;
            for (int i = 0; i < wave.EnemyPrefabs.Count; i++)
            {
                SpawnEnemy(wave.EnemyPrefabs[i],wave.Name);
                yield return new WaitForSeconds(1f / wave.Rate);
            }
            _isSpawning = false;
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
            public float Rate;
            public string Name;
            public List<GameObject> EnemyPrefabs;
        }
    }
}
