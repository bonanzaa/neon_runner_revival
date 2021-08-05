using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class EnemyMarker : MonoBehaviour
    {
        void Start()
        {
            Destroy(gameObject, 3f);
        }       
    }
}
