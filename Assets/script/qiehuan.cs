using UnityEngine;
using System.Collections;

public class qiehuan : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    //public Texture2D[] btn;
    //  public string doUpMethodName;
    // public string doDownMethodName;
    //  Rect rc;
    // int index = 0;
    public void onclick() {
        Application.LoadLevel("s01");
    }

    // Update is called once per frame
    void Update () {
        
        //if (Input.GetMouseButtonUp(0))
        //            {
        //                 //rc = guiTexture.pixelInset;
        //                 rc.x += transform.position.x * Screen.width;
        //                 rc.y += transform.position.y * Screen.height;
        //                 if (rc.Contains(Input.mousePosition))
        //                     {
        //                         index = 1;
        //                        SendMessage(doUpMethodName, index);//按钮弹起时的事件触发
        //                     }
        //             }
    }
}
