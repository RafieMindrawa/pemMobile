#pragma strict

function QuitGame(){
	Debug.Log("Game Keluar...");
	Application.Quit();
	}
	
function StartGame(){
	Application.LoadLevel("remilia");
	}