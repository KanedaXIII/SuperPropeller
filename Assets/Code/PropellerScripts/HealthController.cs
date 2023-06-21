using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour, IDoDamage, IDoHealth
{
    [SerializeField] private int _initialLife;

    private int _currentLife;

    [Header("Dependencies")]
    //[SerializeField]private GameplayUI _gameplayUI;

    public  GameStateChanger gameState;

    public GameStateSO gameOverState;

    public int CurrentLife { get => _currentLife; }

    private void Awake() {
        Reset();
    }

    public void Reset()
    {
        _currentLife = _initialLife;
        //_gameplayUI.SetLife(_currentLife.ToString());
    }

    public void Damage(int damage)
    {
        _currentLife -= damage;

        //_gameplayUI.SetLife(_currentLife.ToString());

       if (_currentLife <= 0)
        {
            GameOver();
        }
    }

    public int CurrentHealth()
    {
        return _currentLife;
    }

    public void Health(int health)
    {
        _currentLife += health;
    }

    private void GameOver()
    {
        gameState.SetGameState(gameOverState);
    }
}
