using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    public float playerspeed;

    public GameObject projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed * Time.deltaTime);
        }

       if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile , transform.position , transform.rotation);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeed *  Time.deltaTime);
        }

        if (transform.position.x >= 9.5f)
        {
            transform.position = new Vector3(-9.5f, -4, 0);

        }

        else if (transform.position.x <= -9.5f)
        {
            transform.position = new Vector3(9.5f, -4f, 0);

        }
     }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject); 

    }


}
        
        



        





