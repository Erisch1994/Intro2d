using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SizeSlider : MonoBehaviour
{
    public float sizeScale;
    public float minSize;
    public float maxSize;
    public Slider slider;
    private float step;
    // Start is called before the first frame update
    void Start()
    {
        sizeScale = transform.localScale.x;
        float difference = maxSize - minSize;
        step = difference / 9;
        slider.maxValue = 9;
        slider.minValue = 1;
        slider.value = 5;
        slider.wholeNumbers = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sizeScale += -step;
            slider.value -= 1;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sizeScale += step;
            slider.value += 1;
        }

        if (sizeScale < minSize )
        {
            sizeScale = minSize;
        }
        if (sizeScale >maxSize)
        {
            sizeScale = maxSize;
        }

            Vector3 scale = new Vector3(sizeScale, sizeScale, sizeScale);
            this.transform.localScale = scale;
        
    }
}