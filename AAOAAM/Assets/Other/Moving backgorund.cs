using UnityEngine;

public class Movingbackgorund : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    //if thenumber goes negative then it starts scrolling backwards, this controlls the speed.

    private float offset;
    private Material mat;



    void Start()
    {
        mat = GetComponent<Renderer>().material;
        //grabs the background?
    }

    // Update is called once per frame
    void Update()
    {
        //calculates the offset 

        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
