using System.Collections;
using UnityEngine;

public class NpcMonkey : MonoBehaviour
{
    bool isSaved = false;
    private Renderer rend;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rend = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isSaved && Input.GetKey(KeyCode.Mouse0))
        {
            isSaved = true;
            StartCoroutine(SavingSequence());
        }
    }


    private IEnumerator SavingSequence()
    {
        //rend.material.color = Color.green;
        MonkeyManager.Instance.savedMonkeys++;
        MonkeyManager.Instance.usableMonkeys++;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
