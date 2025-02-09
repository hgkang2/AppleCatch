using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text time_Text;
    float time = 30.0f;
    public Text point_Text;
    int point = 0;

    public GameManager generator;
    public void GetApple()
    {
        point += 100;
        time += 1;
    }
    public void GetBomb()
    {
        point /= 2;
        time /= 2;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(10000.0f, 0, 0);
        }
        else if (this.time >= 0 && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 3);
        }
        else if (this.time >= 5 && this.time < 12)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.5f, -0.05f, 6);
        }
        else if (this.time >= 12 && this.time <23)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(0.8f, -0.04f, 4);
        }
        else if (this.time >= 23 && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
        }


            time_Text.text = time.ToString();
        point_Text.text = point.ToString() + "point";
    }
}
