using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UIElements;

public class ParrallaxController : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parrallaxEffect;//Speed Background Moves Relative to Camera
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance =cam.transform.position.x * parrallaxEffect;//0 = Move with cam || 1 = Wont Move || 0.5 = half
        float movement = cam.transform.position.x *(1 - parrallaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y,transform.position.x);
        if(movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
