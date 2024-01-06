using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Material mymaterial;

    private GameObject score;
    int scorebase = 0;

    private int SmallCloudPoint = -10;
    private int LargeCloudPoint = 20;
    private int SmallStarPoint= 30;
    private int LargeStarPoint = 40;

    // Start is called before the first frame update
    void Start()
    {
        this.mymaterial = GetComponent<Renderer>().material;
        this.score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other) 
        {
        if (tag == "SmallStarTag")
        {
            scorebase += SmallStarPoint;
            this.score.GetComponent<Text>().text = "Score" + scorebase;
        }
        else if (tag == "LargeStarTag")
        {
            scorebase += LargeStarPoint;
            this.score.GetComponent<Text>().text = "Score" + scorebase;
        }
        else if (tag == "SmallCloudTag")
        {
            scorebase += SmallCloudPoint;
            this.score.GetComponent<Text>().text = "Score" + scorebase;
        }
        else if (tag == "LargeCloudTag")
        {
            scorebase += LargeCloudPoint;
            this.score.GetComponent<Text>().text = "Score" + scorebase;
        }
    }
}
