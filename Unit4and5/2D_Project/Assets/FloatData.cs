using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    public float power;
    public float reset;

    public void UpdateValue(float num)
    {
        value += num;
    }

        public void PowerUpdate(float num)
    {
        power += num;
    }
        public void UpdateValueTitan(float num)
    {
        value += num;
    }

        public void PowerUpdateTitan(float num)
    {
        power += num;
    }

    public void ResetUpdate(float num)
    {
        value = num;
    }

}