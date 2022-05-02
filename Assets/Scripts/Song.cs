using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Song : MonoBehaviour
{
    public string songDataPath = "ExpertPlus";
    public string songPath = "";
    public GameObject blueNote;
    public GameObject redNote;

    [Serializable]
    public class note
    {
        public float _time;
        public int _lineIndex;
        public int _lineLayer;
        public int _type;
        public int _cutDirection;
    }

    [Serializable]
    public class SongData
    {
        public string _version;
        public note[] _notes;
    }

    private float time;
    private SongData songData;
    private int noteSkip = 0;

    void Start()
    {
        TextAsset asset = Resources.Load<TextAsset>(songPath);
        songData = JsonUtility.FromJson<SongData>(asset.text);

    }

    private void Update()
    {
        while (noteSkip < songData._notes.Length && time > songData._notes[noteSkip]._time)
        {
            var note = songData._notes[noteSkip];
            float xPos = 0f, yPos = 0f;
            Quaternion rot = Quaternion.identity;

            switch (note._lineIndex)
            {
                case 0: xPos = -0.75f; break;
                case 1: xPos = -0.25f; break;
                case 2: xPos = 0.25f; break;
                case 3: xPos = 0.75f; break;
            }

            switch (note._lineLayer)
            {
                case 0: yPos = 0.25f; break;
                case 1: yPos = 0.75f; break;
                case 2: yPos = 1.25f; break;
            }

            switch (note._cutDirection)
            {
                case 0: rot = Quaternion.Euler(new Vector3(0, 0, 180)); break;
                case 1: rot = Quaternion.Euler(new Vector3(0, 0, 0)); break;
                case 2: rot = Quaternion.Euler(new Vector3(0, 0, -90)); break;
                case 3: rot = Quaternion.Euler(new Vector3(0, 0, 90)); break;
                case 4: rot = Quaternion.Euler(new Vector3(0, 0, -135)); break;
                case 5: rot = Quaternion.Euler(new Vector3(0, 0, 135)); break;
                case 6: rot = Quaternion.Euler(new Vector3(0, 0, -45)); break;
                case 7: rot = Quaternion.Euler(new Vector3(0, 0, 45)); break;
                case 8: rot = Quaternion.Euler(new Vector3(0, 0, 0)); break;
            }

            switch(note._type)
            {
                case 0: Instantiate(blueNote, new Vector3(xPos, yPos, 8f), rot); break;
                case 1: Instantiate(redNote, new Vector3(xPos, yPos, 8f), rot); break;
            }

            noteSkip++;
        }
        time += Time.deltaTime;
    }

}
