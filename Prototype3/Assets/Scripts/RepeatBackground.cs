using UnityEngine;

public class RepeatBackground : MonoBehaviour
{ 
    //starting Position
    private Vector3 startPos;
    //repeat width
    private float repeatWidth;
    private const string gameOverString = "Game Over!";
    // Start is called before the first frame update
    void Start()
    {
        //set the start position
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //if we have gone past our reset position, re position
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
