using UnityEngine;
using Core;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [Header("Attributes")]
        [SerializeField] private KeyCode exitAppKey;
        private Game _game;

        public void Construct(Game game)
        {
            _game = game;
        }
        private void Update()
        {
            ListenExitApp();
        }
        private void ListenExitApp()
        {
            if (Input.GetKeyDown(exitAppKey))
            {
                _game.FinishGame();
            }
        }
    }
}