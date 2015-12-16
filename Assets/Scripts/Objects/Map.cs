using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Objects
{
    public class Map
    {
        private string[,] mapContent;

        public int MapMaxX
        {
            get { return Convert.ToInt32(mapContent.GetLongLength(0)); }
            //set { mapMaxX = value; }
        }

        public int MapMaxY
        {
            get { return Convert.ToInt32(mapContent.GetLongLength(1)); }
            //set { mapMaxY = value; }
        }

        public string[,] MapContent
        {
            get { return mapContent; }
        }

        public Map(TextAsset mapAsset)
        {
            string [] rows = mapAsset.text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int mapMaxY = rows.Length;
            int mapMaxX = rows[0].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Length;

            mapContent = new string[mapMaxX, mapMaxY];

            for(int y = 0; y< mapContent.GetLength(1); y++)
            {
                string[] cols = rows[y].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                for (int x = 0; x< mapContent.GetLongLength(0); x++)
                {
                    mapContent[x, y] = cols[x] as string;
                }
            }
        }
    
    }
}
