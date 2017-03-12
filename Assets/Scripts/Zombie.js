#pragma strict

@HideInInspector
var health : float = 200; 
var maxHealth : float = 200;

static var dead : boolean = false;

function Start () {
    dead = false;
    health = maxHealth;
}

function Update () {
	
}
