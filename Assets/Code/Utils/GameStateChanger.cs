using UnityEngine;

public class GameStateChanger : MonoBehaviour
{
    [Header("Dependencies")] public GameManagerSO gameManagerSO;

    public void SetGameState(GameStateSO gameState)
    {
        gameManagerSO.SetGameState(gameState);
    }

    public void RestorePrevious()
    {
        gameManagerSO.RestorePreviousState();
    }
}
