using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RayCast : MonoBehaviour {


    public GameObject objText;
   
    public GameObject objTextPlural;

    public manager controladorManager;

    public bool semaforo = false;

    private float contador = 0;

    public GameObject scriptManager;

    //CANVAS
    
    public GameObject canvasdesk;
    public GameObject canvasfloor;
    public GameObject canvaswindow;
    public GameObject canvaswindow2;
    public GameObject canvaswall;
    public GameObject canvasceiling;
    public GameObject canvasdoor;
    public GameObject canvasknob;
    public GameObject canvasfireKnob;
    public GameObject canvascupBoard;
    public GameObject canvassofa;
    public GameObject canvasarmChair;
    public GameObject canvaslamp;
    public GameObject canvasfloorLamp;
    public GameObject canvasmap;
    public GameObject canvasfan;
    public GameObject canvaspencilHolder;
    public GameObject canvaspen;
    public GameObject canvaspencil;
    public GameObject canvasmonitor;
    public GameObject canvaslaptop;
    public GameObject canvascup;
    public GameObject canvasnoteBook;
    public GameObject canvascarpet;
    public GameObject canvasshelves;
    public GameObject canvascan;
    public GameObject canvasbook;
    public GameObject canvastelevision;
    public GameObject canvasvase;
    public GameObject canvaschair;

    public GameObject canvasMenu;
    public GameObject canvasTextMenu;
    public GameObject chargeMenu;

    public RawImage tvImage;

    //GAMEOBJECTS
    public GameObject esfera;
    public GameObject desk;
    public GameObject floor;
    public GameObject window;
    public GameObject wall;
    public GameObject ceiling;
    public GameObject door;
    public GameObject knob;
    public GameObject fireKnob;
    public GameObject cupBoard;
    public GameObject sofa;
    public GameObject armChair;
    public GameObject lamp;
    public GameObject floorLamp;
    public GameObject map;
    public GameObject fan;
    public GameObject pencilHolder;
    public GameObject pen;
    public GameObject pencil;
    public GameObject monitor;
    public GameObject laptop;
    public GameObject cup;
    public GameObject noteBook;
    public GameObject carpet;
    public GameObject shelves;
    public GameObject can;
    public GameObject book;
    public GameObject television;
    public GameObject vase;
    public GameObject chair;

    





    // Use this for initialization
    void Start () {
       
        Material material = new Material(Shader.Find("Custom/GlowShader"));

        Material material1 = new Material(Shader.Find("Custom/silouete_Shader"));

        controladorManager = GameObject.Find("ManagerScript").GetComponent<manager>();

        scriptManager = GameObject.Find("ManagerScript");

       
    }

    // Update is called once per frame
    void Update ()
    {
        RaycastHit hit;
   

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
     

        Debug.DrawRay(transform.position, forward, Color.green);

       
        tvImage.color = Color.Lerp(Color.cyan, Color.white, Mathf.PingPong(Time.time, 3));
       


        if (Physics.Raycast(transform.position, forward, out hit))
            {
              
                //DESK
                if (hit.transform.gameObject == desk)
                {
                    desk.GetComponent<Renderer>().material.SetFloat("_RimPower", 1.0f);
                    desk.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);
                    desk.GetComponent<Renderer>().material.SetColor("_ColorTint", Color.cyan);

                canvasdesk.SetActive(true);
                canvasdesk.transform.localScale = Vector3.Slerp(canvasdesk.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f),Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvasdesk.GetComponentInChildren<Text>().text = "Skrivboard";
                    GameObject.Find("deskPlural").GetComponent<Text>().text = "Skrivboard";
                }

                if (controladorManager.Language == 2)
                {
                    canvasdesk.GetComponentInChildren<Text>().text = "مكتب";
                    GameObject.Find("deskPlural").GetComponent<Text>().text = "مكاتب";
                }
                if (controladorManager.Language == 3)
                {
                    canvasdesk.GetComponentInChildren<Text>().text = "Escritorio";
                    GameObject.Find("deskPlural").GetComponent<Text>().text = "Escritorios";
                }

            }
                else
                {
                canvasdesk.SetActive(false);
                canvasdesk.transform.localScale =  new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                desk.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                desk.GetComponent<Renderer>().material.SetColor("_ColorTint", Color.black);

                }

                //FLOOR
                if (hit.transform.gameObject == floor)
                {
                    floor.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    floor.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvasfloor.SetActive(true);
                canvasfloor.transform.localScale = Vector3.Slerp(canvasfloor.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvasfloor.GetComponentInChildren<Text>().text = "Golv";
                    GameObject.Find("floorPlural").GetComponent<Text>().text = "Golven";
                }
                if (controladorManager.Language == 2)
                {
                    canvasfloor.GetComponentInChildren<Text>().text = "أرضية";
                    GameObject.Find("floorPlural").GetComponent<Text>().text = "أرضيات";
                }
                if (controladorManager.Language == 3)
                {
                    canvasfloor.GetComponentInChildren<Text>().text = "Suelo";
                    GameObject.Find("floorPlural").GetComponent<Text>().text = "Suelos";
                }
            }
                else
                {
                    floor.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                canvasfloor.SetActive(false);
                canvasfloor.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
            }
                //WINDOWS
                if (hit.transform.gameObject == window)
                {
                    window.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    window.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvaswindow.SetActive(true);
                canvaswindow.transform.localScale = Vector3.Slerp(canvaswindow.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                canvaswindow2.SetActive(true);
                canvaswindow2.transform.localScale = Vector3.Slerp(canvaswindow.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvaswindow.GetComponentInChildren<Text>().text = "Fönster";
                    canvaswindow2.GetComponentInChildren<Text>().text = "Fönster";
                    GameObject.Find("windowhide").GetComponent<Text>().text = "Fönster"; 
                    GameObject.Find("windowPlural1").GetComponent<Text>().text = "Fönstren";
                    GameObject.Find("windowPlural2").GetComponent<Text>().text = "Fönstren";
                    GameObject.Find("windowPlural3").GetComponent<Text>().text = "Fönstren";
                }
                if (controladorManager.Language == 2)
                {
                    canvaswindow.GetComponentInChildren<Text>().text = "شباك";
                    canvaswindow2.GetComponentInChildren<Text>().text = "شباك";
                    GameObject.Find("windowhide").GetComponent<Text>().text = "شباك";
                    GameObject.Find("windowPlural1").GetComponent<Text>().text = "شبابيك";
                    GameObject.Find("windowPlural2").GetComponent<Text>().text = "شبابيك";
                    GameObject.Find("windowPlural3").GetComponent<Text>().text = "شبابيك";
                }
                if (controladorManager.Language == 3)
                {
                    canvaswindow.GetComponentInChildren<Text>().text = "Ventana";
                    canvaswindow2.GetComponentInChildren<Text>().text = "Ventana";
                    GameObject.Find("windowhide").GetComponent<Text>().text = "Ventana";
                    GameObject.Find("windowPlural1").GetComponent<Text>().text = "Ventanas";
                    GameObject.Find("windowPlural2").GetComponent<Text>().text = "Ventanas";
                    GameObject.Find("windowPlural3").GetComponent<Text>().text = "Ventanas";
                }
            }
                else
                {
                canvaswindow.SetActive(false);
                canvaswindow.transform.localScale = new Vector3(0.0005357979f, 0.0005127271f, 0.0f);
                canvaswindow2.SetActive(false);
                canvaswindow2.transform.localScale = new Vector3(0.0005357979f, 0.0005127271f, 0.0f);
                window.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //WALL
                if (hit.transform.gameObject == wall)
                {
                    wall.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    wall.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvaswall.SetActive(true);
                canvaswall.transform.localScale = Vector3.Slerp(canvaswall.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvaswall.GetComponentInChildren<Text>().text = "Vägg";
                    GameObject.Find("wallPlural").GetComponent<Text>().text = "Väggar";
                    GameObject.Find("wallPlural2").GetComponent<Text>().text = "Väggar";
                }
                if (controladorManager.Language == 2)
                {
                    canvaswall.GetComponentInChildren<Text>().text = "جدار";
                    GameObject.Find("wallPlural").GetComponent<Text>().text = "جدران";
                    GameObject.Find("wallPlural2").GetComponent<Text>().text = "جدران";
                }
                if (controladorManager.Language == 3)
                {
                    canvaswall.GetComponentInChildren<Text>().text = "Muro";
                    GameObject.Find("wallPlural").GetComponent<Text>().text = "Muros";
                    GameObject.Find("wallPlural2").GetComponent<Text>().text = "Muros";
                }
            }
            else
                {
                canvaswall.SetActive(false);
                canvaswall.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                wall.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //CEILING
                if (hit.transform.gameObject == ceiling)
                {
                    ceiling.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    ceiling.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvasceiling.SetActive(true);
                canvasceiling.transform.localScale = Vector3.Slerp(canvasceiling.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasceiling.GetComponentInChildren<Text>().text = "Tak";
                    GameObject.Find("ceilingPlural").GetComponent<Text>().text = "I tak";
                }
                if (controladorManager.Language == 2)
                {
                    canvasceiling.GetComponentInChildren<Text>().text = "فقس";
                    GameObject.Find("ceilingPlural").GetComponent<Text>().text = "أسقف";
                }
                if (controladorManager.Language == 3)
                {
                    canvasceiling.GetComponentInChildren<Text>().text = "Techo";
                    GameObject.Find("ceilingPlural").GetComponent<Text>().text = "Techos";
                }
            }
                else
                {
                canvasceiling.SetActive(false);
                canvasceiling.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                ceiling.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //DOOR
                if (hit.transform.gameObject == door)
                {
                    door.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                door.GetComponent<Renderer>().material.SetFloat("_Outline", 0.03f);
                door.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvasdoor.SetActive(true);
                canvasdoor.transform.localScale = Vector3.Slerp(canvasdoor.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasdoor.GetComponentInChildren<Text>().text = "Dörr";
                    GameObject.Find("doorPlural").GetComponent<Text>().text = "Dörrar";
                }
                if (controladorManager.Language == 2)
                {
                    canvasdoor.GetComponentInChildren<Text>().text = "باب";
                    GameObject.Find("doorPlural").GetComponent<Text>().text = "أبواب";
                }
                if (controladorManager.Language == 3)
                {
                    canvasdoor.GetComponentInChildren<Text>().text = "Puerta";
                    GameObject.Find("doorPlural").GetComponent<Text>().text = "Puertas";
                }
            }
            else
            {
                canvasdoor.SetActive(false);
                canvasdoor.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                door.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //HANDLE
                if (hit.transform.gameObject == knob)
                {
                    knob.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    knob.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvasknob.SetActive(true);
                canvasknob.transform.localScale = Vector3.Slerp(canvasknob.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasknob.GetComponentInChildren<Text>().text = "Handtag";
                    GameObject.Find("knobPlural").GetComponent<Text>().text = "Handtagen";
                }
                if (controladorManager.Language == 2)
                {
                    canvasknob.GetComponentInChildren<Text>().text = "مقبض";
                    GameObject.Find("knobPlural").GetComponent<Text>().text = "مقابض";
                }
                if (controladorManager.Language == 3)
                {
                    canvasknob.GetComponentInChildren<Text>().text = "Mango";
                    GameObject.Find("knobPlural").GetComponent<Text>().text = "Mangos";
                }
            }
            else
                {
                canvasknob.SetActive(false);
                canvasknob.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                knob.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //FIREKNOB
                if (hit.transform.gameObject == fireKnob)
                {
                    fireKnob.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    fireKnob.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

      
                    canvasfireKnob.SetActive(true);
                canvasfireKnob.transform.localScale = Vector3.Slerp(canvasfireKnob.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasfireKnob.GetComponentInChildren<Text>().text = "Nödutgång";
                    GameObject.Find("knobFirePlural").GetComponent<Text>().text = "Nödutgångar";
                }
                if (controladorManager.Language == 2)
                {
                    canvasfireKnob.GetComponentInChildren<Text>().text = "مخرج طوارئ";
                    GameObject.Find("knobFirePlural").GetComponent<Text>().text = "مخارج طوارئ";
                }
                if (controladorManager.Language == 3)
                {
                    canvasfireKnob.GetComponentInChildren<Text>().text = "Salida de emergencia";
                    GameObject.Find("knobFirePlural").GetComponent<Text>().text = "Salidas de emergencia";
                }
            }
                else
                {
                canvasfireKnob.SetActive(false);
                canvasfireKnob.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                fireKnob.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //CUPBOARD
                if (hit.transform.gameObject == cupBoard)
                {
                    cupBoard.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    cupBoard.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvascupBoard.SetActive(true);
                canvascupBoard.transform.localScale = Vector3.Slerp(canvascupBoard.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvascupBoard.GetComponentInChildren<Text>().text = "Skåp";
                    GameObject.Find("cupboardPlural").GetComponent<Text>().text = "Skåpen";
                }
                if (controladorManager.Language == 2)
                {
                    canvascupBoard.GetComponentInChildren<Text>().text = "خزانة";
                    GameObject.Find("cupboardPlural").GetComponent<Text>().text = "خزانات";
                }
                if (controladorManager.Language == 3)
                {
                    canvascupBoard.GetComponentInChildren<Text>().text = "Armario";
                    GameObject.Find("cupboardPlural").GetComponent<Text>().text = "Armarios";
                }
            }
                else
                {
                canvascupBoard.SetActive(false);
                canvascupBoard.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                cupBoard.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //SOFA
                if (hit.transform.gameObject == sofa)
                {
                    sofa.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    sofa.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvassofa.SetActive(true);
                canvassofa.transform.localScale = Vector3.Slerp(canvassofa.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvassofa.GetComponentInChildren<Text>().text = "Soffa";
                    GameObject.Find("sofaPlural").GetComponent<Text>().text = "Soffor";
                }
                if (controladorManager.Language == 2)
                {
                    canvassofa.GetComponentInChildren<Text>().text = "أريكة";
                    GameObject.Find("sofaPlural").GetComponent<Text>().text = "الأرائك";
                }
                if (controladorManager.Language == 3)
                {
                    canvassofa.GetComponentInChildren<Text>().text = "Sofá";
                    GameObject.Find("sofaPlural").GetComponent<Text>().text = "Sofás";
                }
            }
                else
                {
                canvassofa.SetActive(false);
                canvassofa.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                sofa.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //ARMCHAIR
                if (hit.transform.gameObject == armChair)
                {
                    armChair.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    armChair.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvasarmChair.SetActive(true);
                canvasarmChair.transform.localScale = Vector3.Slerp(canvasarmChair.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasarmChair.GetComponentInChildren<Text>().text = "Fåtölj";
                    GameObject.Find("armchairPlural").GetComponent<Text>().text = "Fåtöljer";
                }
                if (controladorManager.Language == 2)
                {
                    canvasarmChair.GetComponentInChildren<Text>().text = "أريكة";
                    GameObject.Find("armchairPlural").GetComponent<Text>().text = "الأرائك";
                }
                if (controladorManager.Language == 3)
                {
                    canvasarmChair.GetComponentInChildren<Text>().text = "Sillón";
                    GameObject.Find("armchairPlural").GetComponent<Text>().text = "Sillones";
                }
            }
                else
                {
                canvasarmChair.SetActive(false);
                canvasarmChair.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                armChair.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //LAMP
                if (hit.transform.gameObject == lamp)
                {
                    lamp.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    lamp.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvaslamp.SetActive(true);
                canvaslamp.transform.localScale = Vector3.Slerp(canvaslamp.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvaslamp.GetComponentInChildren<Text>().text = "Lampa";
                    GameObject.Find("lampPlural").GetComponent<Text>().text = "Lampor";
                }
                if (controladorManager.Language == 2)
                {
                    canvaslamp.GetComponentInChildren<Text>().text = "مصباح";
                    GameObject.Find("lampPlural").GetComponent<Text>().text = "مصابيح";
                }
                if (controladorManager.Language == 3)
                {
                    canvaslamp.GetComponentInChildren<Text>().text = "Lámpara";
                    GameObject.Find("lampPlural").GetComponent<Text>().text = "Lámparas";
                }
            }
                else
                {
                canvaslamp.SetActive(false);
                canvaslamp.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                lamp.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //FLOORLAMP
                if (hit.transform.gameObject == floorLamp)
                {
                    floorLamp.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    floorLamp.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvasfloorLamp.SetActive(true);
                canvasfloorLamp.transform.localScale = Vector3.Slerp(canvasfloorLamp.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasfloorLamp.GetComponentInChildren<Text>().text = "Lampa";
                    GameObject.Find("floorlampPlural").GetComponent<Text>().text = "Lampor";
                }
                if (controladorManager.Language == 2)
                {
                    canvasfloorLamp.GetComponentInChildren<Text>().text = "مصباح";
                    GameObject.Find("floorlampPlural").GetComponent<Text>().text = "مصابيح";
                }
                if (controladorManager.Language == 3)
                {
                    canvasfloorLamp.GetComponentInChildren<Text>().text = "Lámpara";
                    GameObject.Find("floorlampPlural").GetComponent<Text>().text = "Lámparas";
                }
            }
                else
                {
                canvasfloorLamp.SetActive(false);
                canvasfloorLamp.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                floorLamp.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //MAP
                if (hit.transform.gameObject == map)
                {
                    map.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    map.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvasmap.SetActive(true);
                canvasmap.transform.localScale = Vector3.Slerp(canvasmap.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasmap.GetComponentInChildren<Text>().text = "Karta";
                    GameObject.Find("mapPlural").GetComponent<Text>().text = "Kartor";
                }
                if (controladorManager.Language == 2)
                {
                    canvasmap.GetComponentInChildren<Text>().text = "خريطة";
                    GameObject.Find("mapPlural").GetComponent<Text>().text = "خرائط";
                }
                if (controladorManager.Language == 3)
                {
                    canvasmap.GetComponentInChildren<Text>().text = "Mapa";
                    GameObject.Find("mapPlural").GetComponent<Text>().text = "Mapas";
                }
            }
                else
                {
                canvasmap.SetActive(false);
                canvasmap.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                map.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //PENCILHOLDER
                if (hit.transform.gameObject == pencilHolder)
                {
                    pencilHolder.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    pencilHolder.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvaspencilHolder.SetActive(true);
                canvaspencilHolder.transform.localScale = Vector3.Slerp(canvaspencilHolder.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvaspencilHolder.GetComponentInChildren<Text>().text = "Pennlåda";
                    GameObject.Find("pencilholderPlural").GetComponent<Text>().text = "Pennskrin";
                }
                if (controladorManager.Language == 2)
                {
                    canvaspencilHolder.GetComponentInChildren<Text>().text = "حاملة أقلام";
                    GameObject.Find("pencilholderPlural").GetComponent<Text>().text = "حاملات أقلام";
                }
                if (controladorManager.Language == 3)
                {
                    canvaspencilHolder.GetComponentInChildren<Text>().text = "Porta lápices";
                    GameObject.Find("pencilholderPlural").GetComponent<Text>().text = "Porta lápices";
                }
            }
                else
                {
                canvaspencilHolder.SetActive(false);
                canvaspencilHolder.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                pencilHolder.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //PEN
                if (hit.transform.gameObject == pen)
                {
                    pen.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    pen.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvaspen.SetActive(true);
                canvaspen.transform.localScale = Vector3.Slerp(canvaspen.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvaspen.GetComponentInChildren<Text>().text = "Kulspetspenna";
                    GameObject.Find("penPlural").GetComponent<Text>().text = "Kulspetspennor";
                }
                if (controladorManager.Language == 2)
                {
                    canvaspen.GetComponentInChildren<Text>().text = "قلم";
                    GameObject.Find("penPlural").GetComponent<Text>().text = "أقلام";
                }
                if (controladorManager.Language == 3)
                {
                    canvaspen.GetComponentInChildren<Text>().text = "Bolígrafo";
                    GameObject.Find("penPlural").GetComponent<Text>().text = "Bolígrafos";
                }
            }
            else
                {
                canvaspen.SetActive(false);
                canvaspen.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                pen.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //PENCIL
                if (hit.transform.gameObject == pencil)
                {
                    pencil.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    pencil.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvaspencil.SetActive(true);
                canvaspencil.transform.localScale = Vector3.Slerp(canvaspencil.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvaspencil.GetComponentInChildren<Text>().text = "Blyertspenna";
                    GameObject.Find("pencilPlural").GetComponent<Text>().text = "Blyertspennor";
                }
                if (controladorManager.Language == 2)
                {
                    canvaspencil.GetComponentInChildren<Text>().text = "قلم رصاص";
                    GameObject.Find("pencilPlural").GetComponent<Text>().text = "أقلام رصاص";
                }
                if (controladorManager.Language == 3)
                {
                    canvaspencil.GetComponentInChildren<Text>().text = "Lápiz";
                    GameObject.Find("pencilPlural").GetComponent<Text>().text = "Lápices";
                }
            }
                else
                {
                canvaspencil.SetActive(false);
                canvaspencil.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                pencil.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //MONITOR
                if (hit.transform.gameObject == monitor)
                {
                    monitor.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    monitor.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvasmonitor.SetActive(true);
                canvasmonitor.transform.localScale = Vector3.Slerp(canvasmonitor.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasmonitor.GetComponentInChildren<Text>().text = "Skärm";
                    GameObject.Find("monitorPlural").GetComponent<Text>().text = "Skärmar";
                }
                if (controladorManager.Language == 2)
                {
                    canvasmonitor.GetComponentInChildren<Text>().text = "شاشة";
                    GameObject.Find("monitorPlural").GetComponent<Text>().text = "شاشات";
                }
                if (controladorManager.Language == 3)
                {
                    canvasmonitor.GetComponentInChildren<Text>().text = "Pantalla";
                    GameObject.Find("monitorPlural").GetComponent<Text>().text = "Pantallas";
                }
            }
                else
                {
                canvasmonitor.SetActive(false);
                canvasmonitor.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                monitor.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //LAPTOP
                if (hit.transform.gameObject == laptop)
                {
                    laptop.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    laptop.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvaslaptop.SetActive(true);
                canvaslaptop.transform.localScale = Vector3.Slerp(canvaslaptop.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvaslaptop.GetComponentInChildren<Text>().text = "Bärbar dator";
                    GameObject.Find("laptopPlural").GetComponent<Text>().text = "Bärbara datorer";
                }
                if (controladorManager.Language == 2)
                {
                    canvaslaptop.GetComponentInChildren<Text>().text = "كومبيوتر محمول";
                    GameObject.Find("laptopPlural").GetComponent<Text>().text = "كومبيوترات محمولة";
                }
                if (controladorManager.Language == 3)
                {
                    canvaslaptop.GetComponentInChildren<Text>().text = "Ordenador portátil";
                    GameObject.Find("laptopPlural").GetComponent<Text>().text = "Ordenadores portátiles";
                }
            }
                else
                {
                canvaslaptop.SetActive(false);
                canvaslaptop.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                laptop.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //CUP
                if (hit.transform.gameObject == cup)
                {
                    cup.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    cup.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvascup.SetActive(true);
                canvascup.transform.localScale = Vector3.Slerp(canvascup.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvascup.GetComponentInChildren<Text>().text = "Kopp";
                    GameObject.Find("cupPlural").GetComponent<Text>().text = "Koppar";
                }
                if (controladorManager.Language == 2)
                {
                    canvascup.GetComponentInChildren<Text>().text = "كوب";
                    GameObject.Find("cupPlural").GetComponent<Text>().text = "أكواب";
                }
                if (controladorManager.Language == 3)
                {
                    canvascup.GetComponentInChildren<Text>().text = "Taza";
                    GameObject.Find("cupPlural").GetComponent<Text>().text = "Tazas";
                }
            }
                else
                {
                canvascup.SetActive(false);
                canvascup.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                cup.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //NOTEBOOK
                if (hit.transform.gameObject == noteBook)
                {
                    noteBook.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    noteBook.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvasnoteBook.SetActive(true);
                canvasnoteBook.transform.localScale = Vector3.Slerp(canvasnoteBook.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasnoteBook.GetComponentInChildren<Text>().text = "Anteckningsbok";
                    GameObject.Find("notebookPlural").GetComponent<Text>().text = "Anteckningsböcker";
                }
                if (controladorManager.Language == 2)
                {
                    canvasnoteBook.GetComponentInChildren<Text>().text = "دفتر";
                    GameObject.Find("notebookPlural").GetComponent<Text>().text = "دفاتر";
                }
                if (controladorManager.Language == 3)
                {
                    canvasnoteBook.GetComponentInChildren<Text>().text = "Cuaderno";
                    GameObject.Find("notebookPlural").GetComponent<Text>().text = "Cuadernos";
                }
            }
                else
                {
                canvasnoteBook.SetActive(false);
                canvasnoteBook.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                noteBook.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //CARPET
                if (hit.transform.gameObject == carpet)
                {
                    carpet.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    carpet.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvascarpet.SetActive(true);
                canvascarpet.transform.localScale = Vector3.Slerp(canvascarpet.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvascarpet.GetComponentInChildren<Text>().text = "Matta";
                    GameObject.Find("carpetPlural").GetComponent<Text>().text = "Mattor";
                }
                if (controladorManager.Language == 2)
                {
                    canvascarpet.GetComponentInChildren<Text>().text = "سجادة";
                    GameObject.Find("carpetPlural").GetComponent<Text>().text = "سجاد";
                }
                if (controladorManager.Language == 3)
                {
                    canvascarpet.GetComponentInChildren<Text>().text = "Alfombra";
                    GameObject.Find("carpetPlural").GetComponent<Text>().text = "Alfombras";
                }
            }
                else
                {
                canvascarpet.SetActive(false);
                canvascarpet.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                carpet.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //SHELF
                if (hit.transform.gameObject == shelves)
                {
                    shelves.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    shelves.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);
                    shelves.GetComponent<Renderer>().material.SetColor("_ColorTint", Color.cyan);


                canvasshelves.SetActive(true);
                canvasshelves.transform.localScale = Vector3.Slerp(canvasshelves.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvasshelves.GetComponentInChildren<Text>().text = "Hylla";
                    GameObject.Find("shelfPlural").GetComponent<Text>().text = "Hyllor";
                }
                if (controladorManager.Language == 2)
                {
                    canvasshelves.GetComponentInChildren<Text>().text = "رف";
                    GameObject.Find("shelfPlural").GetComponent<Text>().text = "رفوف";
                }
                if (controladorManager.Language == 3)
                {
                    canvasshelves.GetComponentInChildren<Text>().text = "Estantería";
                    GameObject.Find("shelfPlural").GetComponent<Text>().text = "Estanterías";
                }
            }
                else
                {
                canvasshelves.SetActive(false);
                canvasshelves.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                shelves.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                shelves.GetComponent<Renderer>().material.SetColor("_ColorTint", Color.black);
            }
                //CAN
                if (hit.transform.gameObject == can)
                {
                    can.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    can.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);


                canvascan.SetActive(true);
                canvascan.transform.localScale = Vector3.Slerp(canvascan.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);
                if (controladorManager.Language == 1)
                {
                    canvascan.GetComponentInChildren<Text>().text = "Burk";
                    GameObject.Find("canPlural").GetComponent<Text>().text = "Burkar";
                }
                if (controladorManager.Language == 2)
                {
                    canvascan.GetComponentInChildren<Text>().text = "علبة";
                    GameObject.Find("canPlural").GetComponent<Text>().text = "علب";
                }
                if (controladorManager.Language == 3)
                {
                    canvascan.GetComponentInChildren<Text>().text = "Lata";
                    GameObject.Find("canPlural").GetComponent<Text>().text = "Latas";
                }
            }
                else
                {
                canvascan.SetActive(false);
                canvascan.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                can.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //BOOKS
                if (hit.transform.gameObject == book)
                {
                    book.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    book.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvasbook.SetActive(true);
                canvasbook.transform.localScale = Vector3.Slerp(canvasbook.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvasbook.GetComponentInChildren<Text>().text = "Bok";
                    GameObject.Find("bookPlural").GetComponent<Text>().text = "Böcker";
                }
                if (controladorManager.Language == 2)
                {
                    canvasbook.GetComponentInChildren<Text>().text = "كتاب";
                    GameObject.Find("bookPlural").GetComponent<Text>().text = "كتب";
                }
                if (controladorManager.Language == 3)
                {
                    canvasbook.GetComponentInChildren<Text>().text = "Libro";
                    GameObject.Find("bookPlural").GetComponent<Text>().text = "Libros";
                }
            }
                else
                {
                canvasbook.SetActive(false);
                canvasbook.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                book.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //TELEVISION
                if (hit.transform.gameObject == television)
                {
                    television.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    television.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvastelevision.SetActive(true);
                canvastelevision.transform.localScale = Vector3.Slerp(canvastelevision.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvastelevision.GetComponentInChildren<Text>().text = "Television (TV)";
                    GameObject.Find("TVPlural").GetComponent<Text>().text = "TVs";
                }
                if (controladorManager.Language == 2)
                {
                    canvastelevision.GetComponentInChildren<Text>().text = "تلفاز";
                    GameObject.Find("TVPlural").GetComponent<Text>().text = "تلفزيونات";
                }
                if (controladorManager.Language == 3)
                {
                    canvastelevision.GetComponentInChildren<Text>().text = "Televisión";
                    GameObject.Find("TVPlural").GetComponent<Text>().text = "Televisiones";
                }
            }
                else
                {
                canvastelevision.SetActive(false);
                canvastelevision.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                television.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
                //VASE
                if (hit.transform.gameObject == vase)
                {
                    vase.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                    vase.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvasvase.SetActive(true);
                canvasvase.transform.localScale = Vector3.Slerp(canvasvase.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvasvase.GetComponentInChildren<Text>().text = "Vas";
                    GameObject.Find("vasePlural").GetComponent<Text>().text = "Vaser";
                }
                if (controladorManager.Language == 2)
                {
                    canvasvase.GetComponentInChildren<Text>().text = "مزهرية";
                    GameObject.Find("vasePlural").GetComponent<Text>().text = "مزهريات";
                }
                if (controladorManager.Language == 3)
                {
                    canvasvase.GetComponentInChildren<Text>().text = "Jarrón";
                    GameObject.Find("vasePlural").GetComponent<Text>().text = "Jarrones";
                }
            }
                else
                {
                canvasvase.SetActive(false);
                canvasvase.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                vase.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
                }
            //CHAIR
            if (hit.transform.gameObject == chair)
            {
                chair.GetComponent<Renderer>().material.SetFloat("_RimPower", 2.0f);
                chair.GetComponent<Renderer>().material.SetColor("_RimColor", Color.cyan);

                canvaschair.SetActive(true);
                canvaschair.transform.localScale = Vector3.Slerp(canvaschair.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvaschair.GetComponentInChildren<Text>().text = "Stol";
                    GameObject.Find("chairPlural").GetComponent<Text>().text = "Stolar";
                }
                if (controladorManager.Language == 2)
                {
                    canvaschair.GetComponentInChildren<Text>().text = "كرسي";
                    GameObject.Find("chairPlural").GetComponent<Text>().text = "كراسي";
                }
                if (controladorManager.Language == 3)
                {
                    canvaschair.GetComponentInChildren<Text>().text = "Silla";
                    GameObject.Find("chairPlural").GetComponent<Text>().text = "Sillas";
                }
            }
            else
            {
                canvaschair.SetActive(false);
                canvaschair.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
                chair.GetComponent<Renderer>().material.SetFloat("_RimPower", 30.0f);
            }
            //FAN
            if (hit.transform.gameObject == fan)
            {
                canvasfan.SetActive(true);
                canvasfan.transform.localScale = Vector3.Slerp(canvasfan.transform.localScale, new Vector3(0.0009f, 0.0009f, 0.0f), Time.deltaTime * 7.0f);

                if (controladorManager.Language == 1)
                {
                    canvasfan.GetComponentInChildren<Text>().text = "Fläkt";
                    GameObject.Find("fanPlural").GetComponent<Text>().text = "Fläktar";
                }
                if (controladorManager.Language == 2)
                {
                    canvasfan.GetComponentInChildren<Text>().text = "مروحة";
                    GameObject.Find("fanPlural").GetComponent<Text>().text = "مراوح";
                }
                if (controladorManager.Language == 3)
                {
                    canvasfan.GetComponentInChildren<Text>().text = "Ventilador";
                    GameObject.Find("fanPlural").GetComponent<Text>().text = "Ventiladores";
                }
            }
            else
            {
                canvasfan.SetActive(false);
                canvasfan.transform.localScale = new Vector3(0.0005357976f, 0.000512727f, 0.0f);
            }

            //GO TO MENU
            if (hit.transform.gameObject == canvasMenu)
            {
                contador += Time.deltaTime;
                canvasMenu.transform.localScale = Vector3.Slerp(canvasMenu.transform.localScale, new Vector3(0.0008f, 0.0008f, 0.0f), Time.deltaTime * 7.0f);
                chargeMenu.transform.localScale = Vector3.Slerp(chargeMenu.transform.localScale, new Vector3(3.1f, 5.92f, 1.0f), Time.deltaTime * 1.0f);
                canvasTextMenu.SetActive(true);
                if(controladorManager.Language == 0)
                {
                    canvasTextMenu.GetComponent<Text>().text = "Main Menu";
                }
                if (controladorManager.Language == 1)
                {
                    canvasTextMenu.GetComponent<Text>().text = "Huvudmeny";
                }
                if (controladorManager.Language == 3)
                {
                    canvasTextMenu.GetComponent<Text>().text = "Menú principal";
                }
            }
            else
            {
                canvasMenu.transform.localScale = new Vector3(0.0006976f, 0.000512727f, 0.0f);
                chargeMenu.transform.localScale = new Vector3(0.0f, 5.92f, 1.0f);
                canvasTextMenu.SetActive(false);

            }

        }

        if (contador >= 3.0f && (hit.transform.gameObject == canvasMenu))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
            Destroy(scriptManager);
        }

    }

   

    public float lerpScale(float time)
    {
        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = originalScale + new Vector3(1.0f, 0.0f, 1.0f);
        float originalTime = time;
        return time;
    }

    public GameObject objRaycast(GameObject obj)
    {

        return obj;
    }
   

}



   



   

