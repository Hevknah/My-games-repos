using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This makes the charcter move using the wasd keys
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.up * 10.0f,
                ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.right * 6.0f,
                ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.left * 6.0f,
                ForceMode2D.Impulse);
        }


        //Makes it destroy and the game reset if it goes out of camura veiw
        if (Camera.main.WorldToScreenPoint(transform.position).y < 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }




    }
}
