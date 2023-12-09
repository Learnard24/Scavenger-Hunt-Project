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
        scoreText.text = "ITEM: " + score.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "ITEM: " + score.ToString();

    }

    void Update()
    {

        if (score == 4)
        {
            winText.SetActive(true);
            Time.timeScale = 0;

        }

    }
 }
