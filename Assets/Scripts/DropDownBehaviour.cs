using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownBehaviour : MonoBehaviour
{
    Dropdown m_Dropdown;
    public Text m_Text;

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(m_Dropdown);
        });

        //Initialise the Text to say the first value of the Dropdown
        //m_Text.text = "First Value : " + m_Dropdown.value;
        m_Text.text = "Option A";
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        if(change.value == 0)
        {
            m_Text.text = "Option A";
        }
        if (change.value == 1)
        {
            m_Text.text = "Option B";
        }
        if (change.value == 2)
        {
            m_Text.text = "Option C";
        }
        //m_Text.text = "New Value : " + change.value;
    }


}
