using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("血量拉桿")]
    public Slider HpSlider;
    [Header("血量狀態")]
    public Text info;
    [Header ("顯示當前血量")]
    public Text hpinfo;

    public float HP { get { return HpSlider.value; } } //把 HPSlider 的資料存在HP裡



    [Header("輸入欄位")]
    public InputField Inputword;
    [Header("吃道具狀態")]
    public Text Prop; 


    #region 畫地板
    [Header ("地板素材")]
    public GameObject cube;


    private void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i+1); j++)
            {
                Vector3 pos = new Vector3(i * 2, j*2, 25);

                Instantiate(cube, pos, Quaternion.identity);
            }                 
                       
            
        }
    }

    #endregion
    /* public void CreatFloor(int length,int width)
     {
         for (int j = 0; j < length; j++) // 0 1 2 3 4 5 6 7 8 9 10
         {
             for (int i = 0; i < j ; i++) //   1 2 3 4 5 6 7 8 9 10  
             {
                 // Quaternion.identity 零角度 ; Quaternion.Euler(x,y,z) 歐拉角度
                 // 生成(物件、座標、角度
                 Instantiate(cube, new Vector3(j*2, i*2, 0), Quaternion.Euler(0, 0, 0));// * n 每排 + n 間距

             }
         }
     }*/





    private void Update()
    {

        #region 練習 1 - 血量狀況判斷
          

        if (HP <= 30) { info.text = "危險"; }    
        else if (HP >= 70) { info.text = "安全"; }
        else { info.text = "警告"; }

        hpinfo.text = "目前血量"+ HpSlider .value ;

        #endregion

        #region 練習 2 - 三元運算 (Ternary)寫法

        Prop.text = Inputword.text == "紅水" ? "恢復血量" : Inputword.text == "藍水" ? "恢復魔力" : "你吃錯道具了~";

        #endregion

        #region 喝藥水 - switch 寫法測試        
        /*
               switch (Inputword.text )
        {
            case "紅水":
                Prop.text = "恢復血量";
                break;

            case "藍水":
                Prop.text = "恢復魔力";
                break;

            default:
                Prop.text = "你吃錯道具了請輸入紅水或是藍水~";
                break;
        }
           */

        #endregion


    }




}