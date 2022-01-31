using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMatrix : MonoBehaviour
{
    public GameObject cube;
    public Camera camera;
    public GameObject plane;
    int[][] matrix = new int[][]
    {
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
    };

    // Start is called before the first frame update
    void Start()
    {
        float planeWidth = plane.GetComponent<Renderer>().bounds.size.x;
        float cubeWidth = cube.GetComponent<Renderer>().bounds.size.x;

        int cubeNumberForARow = matrix[0].Length;

        float distance_between_cubes = planeWidth / cubeNumberForARow;

        for (int y = 0; y < matrix.Length; y++)
        {
            for (int x = 0; x < matrix[0].Length; x++)
            {
                float position_z = cube.transform.position.z - (distance_between_cubes * y);
                float position_x = cube.transform.position.x + (distance_between_cubes * x);
                float position_y = cube.transform.position.y;

                Vector3 position = new Vector3(x: position_x, y: position_y, z: position_z);

                Instantiate(cube, position, cube.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                // Do something with the object that was hit by the raycast.

                if (objectHit.CompareTag("CubeTag"))
                {
                    Destroy(objectHit.gameObject);
                }
            }
        }
    }

}
