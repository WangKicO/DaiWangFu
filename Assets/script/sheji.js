#pragma strict

function Start () {

}

var speed : int =5;
var horizontalSpeed : float = 2.0;
var verticalSpeed : float = 2.0;
function Update () {
	var x:float =Input.GetAxis("Horizontal")*Time.deltaTime*speed;
	var z:float =Input.GetAxis("Vertical")*Time.deltaTime*speed;
	transform.Translate(x,0,z);
	//print(x);
	
	

//检测键盘上按键（在y轴方向旋转）
if(Input.GetKey(KeyCode.Q)){
	transform.Rotate(0,-25*Time.deltaTime,0,Space.Self);
}
if(Input.GetKey(KeyCode.E)){
	transform.Rotate(0,25*Time.deltaTime,0,Space.Self);
}
if(Input.GetKey(KeyCode.W)){
	transform.Rotate(-5*Time.deltaTime,0,0,Space.Self);
}
if(Input.GetKey(KeyCode.S)){
	transform.Rotate(5*Time.deltaTime,0,0,Space.Self);
}
//taisheng jiangdi
if(Input.GetKey(KeyCode.H)){
	transform.Translate(0,5*Time.deltaTime,0,Space.Self);
}
if(Input.GetKey(KeyCode.N)){
	transform.Translate(0,-5*Time.deltaTime,0,Space.Self);
}
//if(Input.GetAxis("Mouse X"))
//{
//    transform.Rotate(-5*Time.deltaTime,0,0,Space.Self);
   
//}
////var h : float =  Input.GetAxis ("Mouse X");
//var v : float =  Input.GetAxis ("Mouse Y");
//transform.Rotate (v,0, 0);
}