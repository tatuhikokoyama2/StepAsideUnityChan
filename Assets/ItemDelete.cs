using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    
    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトがUniyuchanの後方へ出たら破棄する
        if (unitychan.transform.position.z - transform.position.z > 2.5f)
        {
            //アイテムを破棄
            Destroy(this.gameObject);
        }

        //Debug.Log("相対距離: " + (unitychan.transform.position.z - transform.position.z));
    }
}
