using NeonRunnerRevival.Assets.Scripts.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts
{
    public class PlayerMarker : MonoBehaviour
    {
        private PlayerTracker _tracker;
        private void Awake()
        {
            ForceGameManagerToKnowAboutMe();
        }

        private void ForceGameManagerToKnowAboutMe()
        {
            // make GameManager a singleton, and better use GameManager.Instance
            // to find it, otherwise this is too slow and will throw null exceptions
            _tracker = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerTracker>();
            _tracker.CashPlayerReference(this);
        }
    }
}
