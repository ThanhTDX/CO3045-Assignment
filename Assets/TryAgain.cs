using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winNotification;
    public Button button;
    public GameObject sphere;
    private Vector3 spawn;
    void Start()
    {
        Debug.Log(spawn.ToString());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onButtonClick()
    {
        winNotification.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
