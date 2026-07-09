using System;
using Core;
using Data;
using TMPro;
using UnityEngine;

namespace UI
{
    public class HintScreenController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI hintText;

        private void OnEnable()
        {
            GameManager.OnHintRequested += Populate;
        }

        private void OnDisable()
        {
            GameManager.OnHintRequested -= Populate;
        }

        private void Populate(StationData data)
        {
            hintText.text = data.hintText;
        }

        public void OnRestartClicked()
        {
            GameManager.Instance.Restart();
        }
    }
}