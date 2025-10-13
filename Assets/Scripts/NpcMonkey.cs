using System.Collections;
using UnityEngine;

public class NpcMonkey : MonoBehaviour
{

    public bool isSaved = false;
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
        if (isSaved)
        {
            StartCoroutine(SavingSequence());
        }
    }
    
    private IEnumerator SavingSequence ()
    {
        rend.material.color = Color.green;
        yield return new WaitForSeconds(2);
        while(transform.position.y <= 10)
        {
            rb.AddForce(Vector3.up);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
