using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float laserspeed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserspeed * Time.deltaTime);
    }
}
