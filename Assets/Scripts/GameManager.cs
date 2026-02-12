using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BossController bosscontroller;
    public GameObject text;         //テキストを格納するための変数
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
        {        // 敵を倒した状態を取得
            isDefeat = bosscontroller.GetEndBoss();
        }

        // ESCで終了
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (isDefeat == true && Input.GetMouseButton(0))
        {
            text.GetComponent<Text>().text = "YOU WIN!!";
            text.SetActive(true);            //テキストをオンにして非表示→表示にする
            SceneManager.LoadScene("24_Scene");
        }
    }
}
