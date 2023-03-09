using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;
    

    public void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
        UpdateLabelPower();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString();
    }

        public void UpdateLabelPower()
    {
        label.text = dataObj.power.ToString();
    }


}
