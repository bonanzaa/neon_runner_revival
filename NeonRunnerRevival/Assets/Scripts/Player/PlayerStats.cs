using NeonRunnerRevival.Assets.Scripts.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts
{
    class PlayerStats : MonoBehaviour
    {
        private InputHandler _inputHandler;
        public PlayerControls Controls;
        [SerializeField]
        private int _currentHp;
        [SerializeField]
        private int _maxHP = 10;
        public float FireRate = 0.1f;


        private void OnEnable() {
            _inputHandler = FindObjectOfType<InputHandler>();
            Controls = _inputHandler.Instance.GetInputReference();
        }

        private void Start()
        {
            _currentHp = _maxHP;
        }

        #region HP Methods
        /// <summary>
        /// returns _currentHp
        /// </summary>
        /// <returns></returns>
        public int GetHp()
        {
            return _currentHp;
        }
        /// <summary>
        /// sets _currentHp to taget value
        /// </summary>
        /// <param name="target"></param>
        public void SetHp(int target)
        {
            _currentHp = target;
        }
        /// <summary>
        /// adds value to _currentHp
        /// </summary>
        /// <param name="value"></param>
        public void ChangeHpBy(int value)
        {
            _currentHp += value;
        }
        /// <summary>
        /// sets _maxHp to target value
        /// </summary>
        /// <param name="target"></param>
        public void SetMaxHp(int target)
        {
            _maxHP = target;
        }
        #endregion
    }
}
