using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModAPI.Attributes;
using TheForest.Utils;
using UnityEngine;

namespace Day
{
    class Day : MonoBehaviour
    {
        [ExecuteOnGameStart]
        private static void AddMeToScene()
        {
            new GameObject("__Day__").AddComponent<Day>();
        }
    }
}

