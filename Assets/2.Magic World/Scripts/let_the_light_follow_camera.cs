using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class let_the_light_follow_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject the_direction_light;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        the_direction_light.gameObject.transform.position = transform.position;
        the_direction_light.gameObject.transform.rotation = transform.rotation;
    }
}
