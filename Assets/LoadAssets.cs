using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
        
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        blueObj = Instantiate(blueObj) as GameObject;
        blueObj.transform.position = new Vector3(-2, 0, 0);
        blueObj.transform.rotation = Quaternion.identity;
        redObj = Instantiate(redObj) as GameObject;
        redObj.transform.position = new Vector3(2, 0, 0);
        redObj.transform.rotation = Quaternion.identity;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
