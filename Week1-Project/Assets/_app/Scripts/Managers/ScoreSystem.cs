using System;
using UnityEngine;

namespace _app.Scripts.Managers
{
    public class ScoreSystem : MonoBehaviour
    {
        private int _score;

        private void OnEnable()
        {
            DelegateManager.scoreEvent += OnScore;
            DelegateManager.deathEvent += OnDeath;
        }

        private void OnDisable()
        {
            DelegateManager.scoreEvent -= OnScore;
            DelegateManager.deathEvent -= OnDeath;
        }

        public void OnScore()
        {
            _score++;
            Debug.Log(_score);
        }

        public void OnDeath()
        {
            _score = 0;
            Debug.Log("Game Over, score reset");
        }
    }
}