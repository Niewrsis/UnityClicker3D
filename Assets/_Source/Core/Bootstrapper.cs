using InputSystem;
using UnityEngine;
using ScoreSystem;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private InputListener inputListener;
        [SerializeField] private ClickableItem _clickableCube, _clickableMovingCube;
        [SerializeField] private ScoreView _scoreView;
        
        private Game _game;
        private Score _score;

        void Awake()
        {
            _score = new();
            _game = new(_score);
            _score.Construct(_scoreView);
            _clickableCube.Construct(_score);
            _clickableMovingCube.Construct(_score);
            _scoreView.Construct(_score);
            inputListener.Construct(_game);

            _game.StartGame();
        }
    }
}