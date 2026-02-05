using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{
    public GameObject player;       //プレイヤーを格納するための変数
    public GameObject text;         //テキストを格納するための変数
    public int nCounterNextScene;   // 次のシーンまでの遷移間隔
    private bool isGoal = false;    //Goalしたかどうか判定する

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        // 画面遷移処理
        {
            ////Goalした後で画面をクリックされたとき
            //if (isGoal && Input.GetMouseButton(0))
            //{
            //    //Restart();
            //
            //    if (Input.GetMouseButtonDown(0))    // クリック時
            //    {
            //        switch (SceneManager.GetActiveScene().name)
            //        {
            //            case "HiyoriTest":   // HiyoriTestの場合
            //                SceneManager.LoadScene("SomaTest");
            //                isGoal = false;     //Goal判定をfalseにする
            //                break;
            //
            //            case "SomaTest":  // SomaTestの場合
            //                SceneManager.LoadScene("HayatoTest");
            //                isGoal = false;     //Goal判定をfalseにする
            //                break;
            //
            //            case "HayatoTest":  // HayatoTestの場合
            //                SceneManager.LoadScene("AkitoTest");
            //                isGoal = false;     //Goal判定をfalseにする
            //                break;
            //
            //            case "AkitoTest":  // AkitoTestの場合
            //                SceneManager.LoadScene("ShumaTest");
            //                isGoal = false;     //Goal判定をfalseにする
            //                break;
            //
            //            case "ShumaTest":  // ShumaTestの場合
            //                SceneManager.LoadScene("KairiTest");
            //                isGoal = false;     //Goal判定をfalseにする
            //                break;
            //
            //            case "KairiTest":  // KairiTestの場合
            //                text.GetComponent<Text>().text = "全てのステージをクリアしました！！";
            //                text.SetActive(true);            //テキストをオンにして非表示→表示にする
            //                break;
            //
            //
            //                //AkitoTest
            //                //HayatoTest
            //                //HiyoriTest
            //                //KairiTest
            //                //ShumaTest
            //                //SomaTest
            //        }
            //
            //    }
            //}
            //
        }

        if (Input.GetKeyDown(KeyCode.Escape) == true)   // ESCキーでゲームを終了
        {
            Application.Quit();
        }
    }

    public bool GetIsGameState()
    {
        return isGoal;
    }

    //当たり判定関数
    private void OnTriggerEnter(Collider other)
    {
        //当たってきたオブジェクトの名前がプレイヤーの名前と同じとき
        if (other.name == player.name && isGoal == false)
        {
            //テキストの内容を変更する
            text.GetComponent<Text>().text = "ゴール！";
            text.SetActive(true);            //テキストをオンにして非表示→表示にする
            isGoal = true;            //Goal判定をTrueにする
        }
    }

    //シーンを再読み込みする
    private void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();        // 現在のScene名を取得する
        SceneManager.LoadScene(loadScene.name);        // Sceneの読み直し
    }
}