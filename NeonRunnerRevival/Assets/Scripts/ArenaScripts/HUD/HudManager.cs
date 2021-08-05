using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace NeonRunnerRevival.Assets.Scripts.ArenaScripts.HUD
{
    class HudManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _wavesLeftDisplay;
        [SerializeField] private TextMeshProUGUI _waveTimeDisplay;
        [SerializeField] private WavesManager _waveManager;
        private int _totalWaves;
        private int _currentWave;
        private float _timeToNextWave;

        private void Awake()
        {
            _totalWaves = _waveManager.GetTotalWaveCount();
            _currentWave = _waveManager.GetCurrentWave();
            WavesManager.WaveHasChanged += OnWaveChange;
            WavesManager.CountdownUpdated += OnCountdownUpdate;
        }

        private void OnCountdownUpdate(float targetVal)
        {
            if (targetVal <= float.Epsilon)
            {
                _waveTimeDisplay.text = "Next Wave 0";
            }
            else
            {
                _waveTimeDisplay.text = $"Next Wave {((int)targetVal).ToString()}";
            }
        }

        private void Start()
        {

        }

        private void OnWaveChange(int newVal)
        {
            _currentWave = _waveManager.GetCurrentWave();
            UpdateCurrentWaveDisplay(_currentWave);
        }

        private void UpdateCurrentWaveDisplay(int currentWave)
        {
            _wavesLeftDisplay.text = $"Wave {currentWave} / {_totalWaves}";
        }
    }
}
