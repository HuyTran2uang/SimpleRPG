using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawner : Spawner
{
    [SerializeField] Character _character = new Human();
    [SerializeField] bool _isSpawned;

    bool IsGameScene()
    {
        return SceneManager.GetActiveScene().name == "Game";
    }

    public void ChoseCharacter(Character character)
    {
        _character = character;
    }

    public void OnDestroyPlayer()
    {
        _isSpawned = false;
    }

    private void Update()
    {
        if (IsGameScene() && _isSpawned == false)
        {
            OnSpawn();
            _isSpawned = true;
        }
    }

    public override void OnSpawn()
    {

    }
}
