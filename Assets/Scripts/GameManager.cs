using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    public PlayerController playerController;
    public UIManager uiManager;
    [Header("References")]
    [SerializeField] private int score;   

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
    }
}
