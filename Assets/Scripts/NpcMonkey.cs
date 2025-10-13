using System.Collections;
using UnityEngine;

public class NpcMonkey : MonoBehaviour
{

    public bool isSaved = false;
    private Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = gameObject.GetComponent<Material>();
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
        material.color = Color.green;
        yield return new WaitForSeconds(4);
    }
}
