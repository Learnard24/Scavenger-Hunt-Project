using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public Text scoreText;
    public GameObject winText;
    public GameObject gameoverText;
    public float items = 0; 
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

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update()
    {

        if (score == items)
        {
            FindObjectOfType<Playermovementscript>().enabled = false;
            FindObjectOfType<Mouselook>().enabled = false;
            winText.SetActive(true);
            UnlockMouse();
        }

    }
 }
