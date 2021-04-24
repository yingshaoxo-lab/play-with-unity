using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hi : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 2f;
    public float forwardInput;
    public float horizontalInput;
    
    public GameObject prefab;
    private int i = 2;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(prefab, transform.position*i, prefab.transform.rotation);
            i = i + 1;
        }
    
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
