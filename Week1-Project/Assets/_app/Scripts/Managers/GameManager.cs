using TMPro;
using UnityEngine;

namespace _app.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public int playerScore;
        public TMP_Text scoreText;
        private void Awake()
        {
            if (instance != null)
            {
                Destroy((this));
            }
            else
            {
                instance = this;
            }
        }

        public void ChangeScore(int scoreAmount)
        {
            playerScore += scoreAmount;
            scoreText.text = "Player Score: " + " " + playerScore.ToString();
        }
    }
}