using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int starPos = 80;
    //ゴール地点
    private int goalPos = 360;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //UnityちゃんのZ座標を保存
    private float position_z = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        
        /* 
                //一定の距離ごとにアイテムを生成
                for (int i = starPos; i < goalPos; i += 15)
                {
                    //どのアイテムを出すのかランダムに設定
                    int num = Random.Range(1, 11);
                    if (num <= 2)
                    {
                        //コーンをx軸方向に一直線に生成
                        for (float j = -1; j <= 1; j += 0.4f)
                        {
                            GameObject cone = Instantiate(conePrefab);
                            cone.transform.position = new Vector3(4 * j, transform.position.y, i);
                        }
                    }
                    else
                    {
                        //レーンごとにアイテムを生成
                        for (int j = -1; j <= 1; j++)
                        {
                            //アイテムの種類を決める
                            int item = Random.Range(1, 11);
                            //アイテムを置く座標のオフセットをランダムに設定
                            int offsetZ = Random.Range(-5, 6);
                            //60%コイン：30%車配置：10%何もなし
                            if (1 <= item && item <= 6)
                            {
                                //コインを生成
                                GameObject coin = Instantiate(coinPrefab);
                                coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                            }
                            else if (7 <= item && item <= 9)
                            {
                                //車を生成
                                GameObject car = Instantiate(carPrefab);
                                car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                            }
                        }
                    }

                }
                */
    }

    // Update is called once per frame
    void Update()
    {
        //15メートルごとにトリガーが来る
        if (this.unitychan.transform.position.z - position_z > 15f)
        {
            //デバッグ
            Debug.Log("トリガー：" + this.unitychan.transform.position.z);

            //一定の距離ごとにアイテムを生成
           // for (int i = starPos; i < goalPos; i += 15)
            //{
                //どのアイテムを出すのかランダムに設定
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        //Unityちゃんの40ｍ先にアイテム生成
                        cone.transform.position = new Vector3(4 * j, transform.position.y, this.unitychan.transform.position.z+40);
                    }
                }
                else
                {
                    //レーンごとにアイテムを生成
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);
                        //アイテムを置く座標のオフセットをランダムに設定
                        int offsetZ = Random.Range(-5, 6);
                        //60%コイン：30%車配置：10%何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab);
                            //Unityちゃんの40ｍ先にアイテム生成
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, this.unitychan.transform.position.z+40 + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車を生成
                            GameObject car = Instantiate(carPrefab);
                        　　//Unityちゃんの40ｍ先にアイテム生成
                        　　car.transform.position = new Vector3(posRange * j, car.transform.position.y, this.unitychan.transform.position.z+40 + offsetZ);
                        }
                    }
                }

           // }

            //Z座標の保存（更新）
            position_z = this.unitychan.transform.position.z;
        }
    }
}
