using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public GameObject HPOne;
    public GameObject HPTwo;
    public GameObject HPThree;

    public int playerCurrentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrentHealth == 3)
        {
            HPOne.SetActive(true);
            HPTwo.SetActive(true);
            HPThree.SetActive(false);

        }
        else if (playerCurrentHealth == 2)
        {
            HPOne.SetActive(true);
            HPTwo.SetActive(true);
            HPThree.SetActive(true);

        }
        else if (playerCurrentHealth == 1)
        {
            HPOne.SetActive(true);
            HPTwo.SetActive(false);
            HPThree.SetActive(false);

        }
        else if (playerCurrentHealth >= 0)
        {
            HPOne.SetActive(false);
            HPTwo.SetActive(false);
            HPThree.SetActive(false);

        }
    }


}
