using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaperCounter : MonoBehaviour
{
    
    public static PaperCounter instance;

    public TMP_Text paperText;
    public int currentPaper = 0;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        paperText.text = "PAPER: " + currentPaper.ToString();
    }

    public void IncreasedPapers(int v)
    {
        currentPaper = v;
        paperText.text = "PAPER: " + currentPaper.ToString();
    }
}
