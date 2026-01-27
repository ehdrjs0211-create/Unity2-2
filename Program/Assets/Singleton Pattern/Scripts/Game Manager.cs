using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] bool state;
    public bool State { get { return state; } }


    private void Start()
    {
        state = true;
    }
    public void Pause()
    {
        state = false;
    }
}