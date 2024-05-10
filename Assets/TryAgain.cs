using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TryAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winNotification;
    public Button button;
    public GameObject sphere;
    private Vector3 spawn;
    void Start()
    {
        float x = sphere.transform.position.x;
        float y = sphere.transform.position.y;
        float z = sphere.transform.position.z;
        spawn = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onButtonClick()
    {
        winNotification.SetActive(false);
        sphere.transform.position = spawn;
    }
}
