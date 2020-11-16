using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleWorldCamera : MonoBehaviour
{
    Camera camera;

    float cameraLeftBorder;

    float cameraRightBorder;

    float cameraTopBorder;

    float cameraBottomBorder;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;

        Debug.Log("cam.orthographicSize: " + camera.orthographicSize);
        Debug.Log("camera.aspect: " + camera.aspect);
        Debug.Log("total: " + camera.aspect * camera.orthographicSize);

        cameraRightBorder = camera.aspect * camera.orthographicSize;
        cameraLeftBorder = -cameraRightBorder;

        cameraTopBorder = camera.orthographicSize;
        cameraBottomBorder = -cameraTopBorder;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");

        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;

        if (posX >= cameraRightBorder && horizontal > 0)
        {
            Debug.Log("right border");
            transform.position = new Vector3(cameraLeftBorder, posY, posZ);
        }

        if (posX <= cameraLeftBorder && horizontal < 0)
        {
            Debug.Log("left border");
            transform.position = new Vector3(cameraRightBorder, posY, posZ);
        }

        if (posY >= cameraTopBorder && vertical > 0)
        {
            Debug.Log("top border");
            transform.position = new Vector3(posX, cameraBottomBorder, posZ);
        }

        if (posY <= cameraBottomBorder && vertical < 0)
        {
            Debug.Log("bottom border");
            transform.position = new Vector3(posX, cameraTopBorder, posZ);
        }
    }
}
