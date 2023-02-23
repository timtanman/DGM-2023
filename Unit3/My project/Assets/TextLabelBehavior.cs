using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

[RequireComponent(typeof(Text))]

public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;

    public void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }

}
