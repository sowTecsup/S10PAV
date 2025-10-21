using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager gm;
    public TMP_Text txtScore;


    void Start()
    {
        gm.OnAddScore += UpdateScoreText;

    }

    public void UpdateScoreText()
    {
        txtScore.text = "Score:" + gm.score;
    }
}
