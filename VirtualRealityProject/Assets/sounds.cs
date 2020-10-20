using UnityEngine;
using System.Collections;

public class sounds : MonoBehaviour {

    public manager controladorManager;

    //AUDIOS ENGLISH........................
        public AudioClip audioDesk;
        public AudioClip audioShelf;
        public AudioClip audioArmChair;
        public AudioClip audioBook;
        public AudioClip audioCan;
        public AudioClip audioCarpet;
        public AudioClip audioCeiling;
        public AudioClip audioChair;
        public AudioClip audioCup;
        public AudioClip audioCupboard;
        public AudioClip audioDoor;
        public AudioClip audioFireExit;
        public AudioClip audioFloor;
        public AudioClip audioHandle;
        public AudioClip audioLamp;
        public AudioClip audioLaptop;
        public AudioClip audioMap;
        public AudioClip audioMonitor;
        public AudioClip audioNotebook;
        public AudioClip audioPen;
        public AudioClip audioPencil;
        public AudioClip audioPencilHolder;
        public AudioClip audioFan;
        public AudioClip audioSofa;
        public AudioClip audioTV;
        public AudioClip audioVase;
        public AudioClip audioWall;
        public AudioClip audioWindow;

        //AUDIOS SWEDISH
        public AudioClip audioDesk_SW;
        public AudioClip audioShelf_SW;
        public AudioClip audioArmChair_SW;
        public AudioClip audioBook_SW;
        public AudioClip audioCan_SW;
        public AudioClip audioCarpet_SW;
        public AudioClip audioCeiling_SW;
        public AudioClip audioChair_SW;
        public AudioClip audioCup_SW;
        public AudioClip audioCupboard_SW;
        public AudioClip audioDoor_SW;
        public AudioClip audioFireExit_SW;
        public AudioClip audioFloor_SW;
        public AudioClip audioHandle_SW;
        public AudioClip audioLamp_SW;
        public AudioClip audioLaptop_SW;
        public AudioClip audioMap_SW;
        public AudioClip audioMonitor_SW;
        public AudioClip audioNotebook_SW;
        public AudioClip audioPen_SW;
        public AudioClip audioPencil_SW;
        public AudioClip audioPencilHolder_SW;
        public AudioClip audioFan_SW;
        public AudioClip audioSofa_SW;
        public AudioClip audioTV_SW;
        public AudioClip audioVase_SW;
        public AudioClip audioWall_SW;
        public AudioClip audioWindow_SW;

        //AUDIOS SPANISH........................
        public AudioClip audioDesk_ES;
        public AudioClip audioShelf_ES;
        public AudioClip audioArmChair_ES;
        public AudioClip audioBook_ES;
        public AudioClip audioCan_ES;
        public AudioClip audioCarpet_ES;
        public AudioClip audioCeiling_ES;
        public AudioClip audioChair_ES;
        public AudioClip audioCup_ES;
        public AudioClip audioCupboard_ES;
        public AudioClip audioDoor_ES;
        public AudioClip audioFireExit_ES;
        public AudioClip audioFloor_ES;
        public AudioClip audioHandle_ES;
        public AudioClip audioLamp_ES;
        public AudioClip audioLaptop_ES;
        public AudioClip audioMap_ES;
        public AudioClip audioMonitor_ES;
        public AudioClip audioNotebook_ES;
        public AudioClip audioPen_ES;
        public AudioClip audioPencil_ES;
        public AudioClip audioPencilHolder_ES;
        public AudioClip audioFan_ES;
        public AudioClip audioSofa_ES;
        public AudioClip audioTV_ES;
        public AudioClip audioVase_ES;
        public AudioClip audioWall_ES;
        public AudioClip audioWindow_ES;


    public AudioClip click;


    public AudioSource source;
    public AudioSource sourceClick;

    // Use this for initialization
    void Start () {

        controladorManager = GameObject.Find("ManagerScript").GetComponent<manager>();

    }
	
	// Update is called once per frame
	void Update () {
        source = GetComponent<AudioSource>();
        


    }

    void OnTriggerEnter(Collider soundEnglish)
    {
        sourceClick.clip = click;
        sourceClick.Play();

        if (soundEnglish.name == "DeskGlow")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioDesk;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioDesk_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioDesk_ES;
            }
            source.PlayDelayed(1.0f);    
        }

        if (soundEnglish.name == "ShelfGlow")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioShelf;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioShelf_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioShelf_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Armchair")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioArmChair;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioArmChair_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioArmChair_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "books")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioBook;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioBook_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioBook_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "can")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioCan;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioCan_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioCan_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "carpet")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioCarpet;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioCarpet_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioCarpet_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Ceiling")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioCeiling;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioCeiling_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioCeiling_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Chair")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioChair;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioChair_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioChair_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "cup")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioCup;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioCup_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioCup_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "cupBoard")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioCupboard;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioCupboard_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioCupboard_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Door")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioDoor;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioDoor_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioDoor_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "FireExit")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioFireExit;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioFireExit_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioFireExit_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Floor")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioFloor;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioFloor_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioFloor_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "FloorLamp" || soundEnglish.name == "lamp")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioLamp;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioLamp_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioLamp_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "knob")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioHandle;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioHandle_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioHandle_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "laptop")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioLaptop;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioLaptop_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioLaptop_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Map")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioMap;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioMap_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioMap_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "monitor")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioMonitor;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioMonitor_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioMonitor_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "notebook")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioNotebook;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioNotebook_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioNotebook_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Pen")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioPen;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioPen_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioPen_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "pencil")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioPencil;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioPencil_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioPencil_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "pencilHolder")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioPencilHolder;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioPencilHolder_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioPencilHolder_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Rotation_Anim")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioFan;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioFan_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioFan_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "sofa")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioSofa;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioSofa_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioSofa_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "television")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioTV;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioTV_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioTV_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Vase")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioVase;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioVase_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioVase_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Wall")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioWall;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioWall_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioWall_ES;
            }
            source.PlayDelayed(1.0f);
        }
        if (soundEnglish.name == "Windows")
        {
            if (controladorManager.Language == 0)
            {
                source.clip = audioWindow;
            }
            if (controladorManager.Language == 1)
            {
                source.clip = audioWindow_SW;
            }
            if (controladorManager.Language == 3)
            {
                source.clip = audioWindow_ES;
            }
            source.PlayDelayed(1.0f);
        }



    }
}
