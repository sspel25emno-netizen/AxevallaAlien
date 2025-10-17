using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int ScoreCounter;
    public TMP_Text textContainer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textContainer.text = "test" + ScoreCounter ;

    }
}
