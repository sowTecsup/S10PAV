using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    public PlayerController playerController;
    public UIManager uiManager;
    [Header("References")]
    [SerializeField] public int score;



    public Action OnAddScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        score++;
        OnAddScore?.Invoke();
    }
}
