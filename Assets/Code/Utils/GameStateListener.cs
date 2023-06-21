using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Events;

namespace Code.Utils
{
    public class GameStateListener : MonoBehaviour
    {
        [Header("Listening to Events")]
        public GameStateSOGameEvent gameStateChangedEvent;

        [Header("Enabled & Disabled Shortcuts")]
        public MonoBehaviour[] components;
        public List<GameStateSO> enabledStates;
        public List<GameStateSO> disabledStates;

        [Header("Actions")]
        public UnityEvent onMainMenuState;
        public UnityEvent onLoadingState;
        public UnityEvent onPlayingState;
        public UnityEvent onPauseState;
        public UnityEvent onGameOverState;

        private void OnEnable()
        {
            gameStateChangedEvent.AddListener(GameStateChanged);
        }

        private void OnDisable()
        {
            gameStateChangedEvent.RemoveListener(GameStateChanged);
        }

        private void GameStateChanged(GameStateSO newGameState)
        {
            InvokeShortcuts(newGameState);
            InvokeActions(newGameState);
        }

        private void InvokeShortcuts(GameStateSO newGameState)
        {
            foreach (var component in components)
            {
                if (enabledStates.Contains(newGameState))
                {
                    component.enabled = true;
                }

                if (disabledStates.Contains(newGameState))
                {
                    component.enabled = false;
                }
            }
        }

        private void InvokeActions(GameStateSO newGameState)
        {
            if (newGameState.stateName == "Main Menu" && onMainMenuState != null)
                onMainMenuState.Invoke();

            if (newGameState.stateName == "Loading" && onLoadingState != null)
                onLoadingState.Invoke();

            if (newGameState.stateName == "Playing" && onPlayingState != null)
                onPlayingState.Invoke();

            if (newGameState.stateName == "Paused" && onPauseState != null)
                onPauseState.Invoke();

            if (newGameState.stateName == "Game Over" && onGameOverState != null)
                onGameOverState.Invoke();
        }
    }
}
