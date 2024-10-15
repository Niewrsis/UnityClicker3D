using ScoreSystem;

namespace Core
{
    public class Game
    {
        private const int _startScoreValue = 5;
        private const int _exitScoreValue = 0;

        private Score _score;
        public Game(Score score)
        {
            _score = score;
        }
        public void StartGame()
        {
            _score.SetScore(_startScoreValue);
        }
        public void FinishGame()
        {
            _score.SetScore(_exitScoreValue);
        }
    }
}