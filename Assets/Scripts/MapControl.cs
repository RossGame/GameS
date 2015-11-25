using UnityEngine;
using System.Collections;

public class MapControl : MonoBehaviour {

    private TextAsset map_1;

	// Use this for initialization
	void Start () {

        GetMap("TestMap");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private TextAsset GetMap(string mapName)
    {
        TextAsset map = Resources.Load("Map/" + mapName, typeof(TextAsset)) as TextAsset;

        return map;
    }
}
