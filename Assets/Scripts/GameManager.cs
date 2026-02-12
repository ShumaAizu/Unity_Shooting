using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BossController bosscontroller;
    private bool isDefeat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isDefeat = false;
     
        if (SceneManager.GetActiveScene().name == "26_Scene")
        {        // “G‚ğ“|‚µ‚½ó‘Ô‚ğæ“¾
            isDefeat = bosscontroller.GetEndBoss();
        }

        // ESC‚ÅI—¹
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (SceneManager.GetActiveScene().name == "26_Scene" && isDefeat == true && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("24_Scene");
        }
    }
}
