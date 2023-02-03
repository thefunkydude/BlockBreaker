using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 2f)] [SerializeField] float gameSpeed;
    [SerializeField] int PointsPerBlockDestroyed, currentScore = 0;
    [SerializeField] TextMeshProUGUI points;

    // Start is called before the first frame update
    void Start()
    {
        points.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void updatePoint()
    {
        currentScore += PointsPerBlockDestroyed;
        points.text = currentScore.ToString();
    }
}