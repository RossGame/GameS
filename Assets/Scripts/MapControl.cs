using UnityEngine;
using System.Collections;
using Assets.Scripts.Objects;
public class MapControl : MonoBehaviour {

    public GameObject floor;
    public GameObject box;

    private TextAsset map_1;

	// Use this for initialization
	void Start () {

        Map map = new Map(GetMap("TestMap"));
        CreateMap(map);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private TextAsset GetMap(string mapName)
    {
        TextAsset map = Resources.Load("Map/" + mapName, typeof(TextAsset)) as TextAsset;
       
        return map;
    }

    private void CreateMap(Map map)
    {
        for(int x = 0; x<map.MapMaxX; x++)
        {
            for(int y = 0; y<map.MapMaxY; y++)
            {
                string mapType = map.MapContent[x, y];

                switch(mapType)
                {
                    case "1":
                        CreatFloor(new Vector3(y, 0 , x));
                        break;
                    case "*":
                        CreatBox(new Vector3(y, 0, x));
                        break;
                    default:
                        break;
                }
            }
        }
    }

    private void CreatFloor(Vector3 coordinate)
    {
        Instantiate(floor, coordinate, new Quaternion());
    }

    private void CreatBox(Vector3 coordinate)
    {
        Instantiate(box, coordinate, new Quaternion());
    }
}
