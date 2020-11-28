using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    public Button IdleImage;
    public Button BlueImage;
    public Button RedImage;

    public Color PressedColor;
    public Color ReleasedColor;

    private ObjectScript obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = FindObjectOfType<ObjectScript>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (null != obj && null != obj.CurrentState)
            showState(obj.CurrentState);

        
    }

    void showState(BaseState state)
    {
        if(state.GetType() == typeof(StateIdle))
        {
            setButtonDown(IdleImage);
            setButtonUp(BlueImage);
            setButtonUp(RedImage);
        }
        else if(state.GetType() == typeof(StateBlue))
        {
            setButtonDown(BlueImage);
            setButtonUp(IdleImage);
            setButtonUp(RedImage);
        }
        else if(state.GetType() == typeof(StateRed))
        {
            setButtonDown(RedImage);
            setButtonUp(IdleImage);
            setButtonUp(BlueImage);
        }
    }

    void setButtonDown(Button button)
    {
        button.image.color = PressedColor;
    }

    void setButtonUp(Button button)
    {
        button.image.color = ReleasedColor;
    }

}
