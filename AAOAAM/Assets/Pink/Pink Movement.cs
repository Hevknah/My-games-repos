using UnityEngine;
using UnityEngine.SceneManagement;

public class PinkMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //PLayer moveent keys this makes it ,move with the arrow keys
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.up * 10.0f,
                ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.right * 6.0f,
                ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.left * 6.0f,
                ForceMode2D.Impulse);

        }

        if (Camera.main.WorldToScreenPoint(transform.position).y < 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



    }


}
