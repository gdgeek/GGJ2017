using UnityEngine;
using System.Collections;
using GDGeek;
[ExecuteInEditMode]
public class VoxelBodyBuilder : MonoBehaviour {
	public bool _refresh = false;
	public VoxelBody _body;
	void Start(){
		StartCoroutine (CountSeconds());

		Debug.Log(" !!!!!!!!!!!!!!!.");  
	}
	// Update is called once per frame
	void head(){
		GameObject obj = null;//new GameObject ("Head");
		Material material = null;
		Transform transform = _body._head.transform.Find ("Head");
		if (transform == null) {
			obj = new GameObject ("Head");
			obj.transform.parent = _body._head.transform;
			TextAsset file = null;
			var br = VoxelReader.ReadFromFile (file);
			VoxelMaker.Building (obj, VoxelReader.ReadFromFile (file), material);
			//maker.
		} else {
			obj = transform.gameObject;	
		}


	}
	void Update () {
		if (_refresh) {
			_body = this.gameObject.GetComponent<VoxelBody> ();
			head ();
			_refresh = false;
		}

	}
	IEnumerator CountSeconds()  
	{  
		int seconds = 0;  

		while(true)  
		{  
			for(float timer = 0; timer < 1; timer += Time.deltaTime)  
				yield return 0;  

			seconds++;  
			Debug.Log(seconds +" seconds have passed since the Coroutine started.");  
		}  
	}  

	private IEnumerator LoadMainCacheGameObject(string path)  
	{  

		WWW www = new WWW(path);  
		yield return www;  
		if (!System.String.IsNullOrEmpty(www.error))  
		{  
			Debug.Log(www.error);  
		}  
		else  
		{  
			Debug.Log (www);
			Debug.Log (www.text);
			Debug.Log (www.assetBundle);
		//	Object main = www.assetBundle.mainAsset;  
			//GameObject.Instantiate(main);  
		}  
	}


}
