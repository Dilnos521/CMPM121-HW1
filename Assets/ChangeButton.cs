using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeButton : MonoBehaviour
{
        // create camera list that can be updated in the inspector
        public List<Camera> Cameras;
        // create frame and button variables
        private VisualElement frame;
        private Button button;


    // Start is called before the first frame update
    void Start()
    {

    }
        void OnEnable()
    {
        // get the UIDocument component (make sure this name matches!)
        var uiDocument = GetComponent<UIDocument>();
        // get the rootVisualElement (the frame component)
        var rootVisualElement = uiDocument.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        // get the button, which is nested in the Frame
        button = frame.Q<Button>("Button");
        //create event listener that calls ChangeCamera() when pressed
        button.RegisterCallback<ClickEvent>(ev => ChangeCamera());
    }

    // initialize click count
    int click = 0;
    private void ChangeCamera()
    {
        EnableCamera(click);
        click++;
        // reset counter so it is not out of bounds (only have four Cameras)
        if(click > 3)
        {
            click = 0;
        }
    }
    private void EnableCamera(int n)
    {
        //disable each of the Cameras
        Cameras.ForEach(cam => cam.enabled = false);
        // enable the selected camera
        Cameras[n].enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
