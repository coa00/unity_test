using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Transform の取得
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        // Transform を取得
        player = GetComponent<Transform>();

        
        
    }

    
    // Update is called once per frame
    void Update()
    {
        // 現在の位置を取得
        Vector3 pos = player.position;

        // 現在の位置に対して、x 座標のみ 10 個ずつ変化させる
        pos.x += 0.01f;

        // 変化させた位置に再設定
        player.position = pos;

        Debug.Log(player.position);

        Debug.Log(player.localPosition);

        Debug.Log(player.eulerAngles);

        Debug.Log(player.localEulerAngles);

        Debug.Log(player.forward);

        Debug.Log(player.up);

        Debug.Log(player.right);

        Debug.Log(player.rotation);

        Debug.Log(player.localRotation);

        Debug.Log(player.localScale);

        Debug.Log(player.lossyScale);
        
    }
}
