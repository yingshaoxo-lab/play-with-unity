using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addGroundWhenCharacterFailing : MonoBehaviour
{
    public GameObject onePieceOfGround;
    private Vector3 lastPosition;
    private Color randomColor;
    private long counting = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // void FixedUpdate()
    void Update()
    {
        if (transform.position.y < 0)
        {
            GameObject newObj = Instantiate(onePieceOfGround, new Vector3(transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);
            newObj.GetComponent<Renderer>().material.color = randomColor;
            CountAndChangeRandomColor();
        }

        if (transform.position.y > 0)
        {
            GameObject newObj = Instantiate(onePieceOfGround, new Vector3(transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);
            newObj.GetComponent<Renderer>().material.color = randomColor;
            CountAndChangeRandomColor();
        }

        // float distance = transform.position.y - lastPosition.y;
        // if (distance < 0 && distance < -2)
        // {
        //     Instantiate(onePieceOfGround, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Quaternion.identity);
        //     lastPosition = transform.position;
        // }
    }

    void CountAndChangeRandomColor()
    {
        if (counting > 100000)
        {
            counting = 0;
        }

        counting++;

        if (counting % 100 == 0)
        {
            randomColor = Random.ColorHSV(0f, 1f, 0f, 1f, 0.85f, 1f);
        }
    }
}
