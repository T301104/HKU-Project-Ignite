using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] GameObject playerModdel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new(playerModdel.transform.position.x, playerModdel.transform.position.y, transform.position.z);
    }
}
