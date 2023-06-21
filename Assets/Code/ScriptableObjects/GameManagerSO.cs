using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "GameManager", menuName = "Scriptable Object/Game Manager")]
public class GameManagerSO : ScriptableObject
{
   public GameStateSO currentState;

   [Header("Broadcasting Events")] 
   public GameStateSOGameEvent gameStateChanged;

   private GameStateSO _previousState;

   public void SetGameState(GameStateSO gameState)
   {
      if (currentState != null)
      {
         _previousState = currentState;
      }

      currentState = gameState;

      if (gameStateChanged )
      {
         gameStateChanged.Raise(gameState);
      }
   }

   public void RestorePreviousState()
   {
      SetGameState(_previousState);
   }
}
