using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreChanger : MonoBehaviour
{

    public TMP_Text _score;
    private int score = 0;
    private int minScore = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Increase()
    {
        score += 5;
        _score.text = score.ToString();
    }
    public void Decrease()
    {       
        score -= 5;
        if (score == -5)
        {
            score = 0;
        }
        _score.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }

}
