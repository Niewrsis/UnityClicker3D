namespace ScoreSystem
{
    public class Score
    {
        private ScoreView _scoreView;
        public int ScoreValue { get; private set; }
        public void Construct(ScoreView scoreView)
        {
            _scoreView = scoreView;
        }
        public void SetScore(int amount)
        {
            ScoreValue = amount;
            _scoreView.UpdateView();
        }
        public void AddScore(int amount)
        {
            ScoreValue += amount;
            _scoreView.UpdateView();
        }
    }
}