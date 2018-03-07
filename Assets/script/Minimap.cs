//using UnityEngine;
//using System.Collections;
  
// public class Minimap : MonoBehaviour 
//  {
//      private Camera minimapCamera;
//      private Transform player;
//      private Vector3 offsetPosition;
//      // Use this for initialization
//     void Start()
//     {
//         minimapCamera = GameObject.FindGameObjectWithTag(Tags.MINIMAP_CAMERA).GetComponent<Camera>();
//         player = GameObject.FindGameObjectWithTag(Tags.PLAYER).transform;
//         offsetPosition = minimapCamera.transform.position - player.position;
//     }

//     void Update()
//    {
//         minimapCamera.transform.position = offsetPosition + player.position;
//    }
//    public void ZoomInButtonClick()
//     {
//         minimapCamera.fieldOfView += 10;
//     }
 
//     public void ZoomOutButtonClick()
//     {
//         minimapCamera.fieldOfView -= 10;
//     }
//}