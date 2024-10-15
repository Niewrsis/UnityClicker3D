using UnityEngine;

namespace ScoreSystem
{
    public class ClickableItem : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private bool isMoving;

        private Score _score;
        public void Construct(Score score)
        {
            _score = score;
        }
        private void OnMouseDown()
        {
            if (isMoving)
            {
                _score.AddScore(1);
            }
            else
            {
                _score.AddScore(-1);
            }
        }
    }
}