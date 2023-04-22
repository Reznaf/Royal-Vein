using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public int cameraZoom = -10;
    GameObject player;
    Camera playercam;
    Vector3 playerPos, camPos;
    int bMAX, bMIN;
    void Start()
    {
        playercam = GetComponent<Camera>();
        player = GameObject.Find("Player");
    }

    
    void Update()
    {
        playerPos = player.transform.position;
        camPos = playercam.transform.position;
        playercam.transform.position = new Vector3(
            Mathf.Clamp(playerPos.x, -20, 20),
            Mathf.Clamp(playerPos.y, -20, 20),
            cameraZoom);
    }

    
}
