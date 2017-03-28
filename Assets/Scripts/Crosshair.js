#pragma strict

var isTriggered : boolean = false;
var crosshairTexture : Texture2D;

function Update(){
    if(Input.GetMouseButton(1)){
        isTriggered = false;
    }
    if(!Input.GetMouseButton(1)){
        isTriggered = true;
    }
}


function OnGUI(){
    if(isTriggered){
        GUI.Label(Rect(Screen.width/2.4, Screen.height/2.1, 200, 200), crosshairTexture);
    }
}
