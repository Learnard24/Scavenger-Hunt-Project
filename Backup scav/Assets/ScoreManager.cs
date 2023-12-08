using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public Text scoreText;

    public GameObject winText;


    int score = 0;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void AddPoint()
    {
        score += 50;
        scoreText.text = "SCORE: " + score.ToString();

    }

    void Update()
    {

        if (score == 100)
        {
            winText.SetActive(true);
            Time.timeScale = 0;

        }

    }
 }
