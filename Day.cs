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

        private bool visible;
        protected GUIStyle labelStyle;
        private string day = "";

        private void OnGUI()
        {
            if (visible)
            {
                // use ModAPI Skin
                GUI.skin = ModAPI.Interface.Skin;

                // apply label style if not existing
                if (this.labelStyle == null)
                {
                    this.labelStyle = new GUIStyle(GUI.skin.label);
                    this.labelStyle.fontSize = 12;
                }

                // create box (background)
                GUI.Box(new Rect(10f, 10f, 300f, 150f), "", GUI.skin.window);

                // Label
                GUI.Label(new Rect(30f, 15f, 200f, 20f), "Day", this.labelStyle);

                // Text-input
                day = GUI.TextField(new Rect(30f, 50f, 200f, 30f), day, GUI.skin.textField);

                // Button
                if (GUI.Button(new Rect(30f, 100f, 80f, 20f), "Set Day"))
                {
                    // TODO
                }
            }
        }
    }
}

