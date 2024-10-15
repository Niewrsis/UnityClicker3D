using UnityEngine;
using TMPro;

namespace ScoreSystem
{
    public class ScoreView : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private TextMeshProUGUI _scoreText;

        private Score _score;
        public void Construct(Score score)
        {
            _score = score;
        }
        public void UpdateView()
        {
            _scoreText.text = _score.ScoreValue.ToString();
        }
    }
}