using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public GameObject prefab;

    private Vector3 start_position_of_a_cube;
    private int i = 1;
    private float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        start_position_of_a_cube = prefab.transform.position;
        distance = start_position_of_a_cube.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab,
            new Vector3(start_position_of_a_cube.x, start_position_of_a_cube.y + (i * distance), start_position_of_a_cube.z),
            prefab.transform.rotation);
            Instantiate(prefab,
            new Vector3(start_position_of_a_cube.x + (i * distance), start_position_of_a_cube.y + (i * distance), start_position_of_a_cube.z + (i * distance)),
            prefab.transform.rotation);
            Instantiate(prefab,
            new Vector3(start_position_of_a_cube.x - (i * distance), start_position_of_a_cube.y + (i * distance), start_position_of_a_cube.z - (i * distance)),
            prefab.transform.rotation);

            Instantiate(prefab,
            new Vector3(start_position_of_a_cube.x + (i * distance), start_position_of_a_cube.y, start_position_of_a_cube.z + (i * distance)),
            prefab.transform.rotation);

            Instantiate(prefab,
            new Vector3(start_position_of_a_cube.x - (i * distance), start_position_of_a_cube.y, start_position_of_a_cube.z - (i * distance)),
            prefab.transform.rotation);

            i = i + 1;
        }
    }
}
