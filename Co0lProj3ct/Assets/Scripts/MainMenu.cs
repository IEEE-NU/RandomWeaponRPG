using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public class MainMenu:MonoBehaviour
	{
		public bool isStart;
		public bool isQuit;

		internal void OnMouseUp(){
			if(isStart)
			{
				SceneManager.LoadScene("Main",LoadSceneMode.Single);
			}
			if (isQuit)
			{
				Application.Quit();
			}
		} 
	}
}

