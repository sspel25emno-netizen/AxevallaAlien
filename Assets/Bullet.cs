using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float laserspeed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserspeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {

            other.GetComponent<enemyScript>().TakeDamage();
        }
    }
}
