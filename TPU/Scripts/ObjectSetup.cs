using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum LAYERS_Mat
{
    mat_layer_Car_traffic,                      //Джидение автотранспорта
    mat_layer_Pedestrian_traffic,               //Джидение пешеходов
    mat_layer_NGPT_traffic,               //Джидение пешеходов


    mat_layer_UDS,                              //УДС
    mat_layer_Transplant_Terminal,              //Терминал пересадки

    mat_layer_Administrative_building,          //Административное здание
    mat_layer_Underground_pedestrian_crossing,  //Подземный пешеходный переход
    mat_layer_Elevated_pedestrian_crossing,     //Надземный пешеходный переход
    mat_layer_Pedestrian_canopy,                //Пешеходный навес

    mat_layer_Interceptive_parking,             //Перехватывающий паркинг
    mat_layer_Parking,                         //Парковка

    mat_layer_Reversal_playground,              //Отстойно-разворотная площадка
    mat_layer_Stopping_NGPT,                    //Остановка НГПТ
    mat_layer_Station_NGPT,                    //Станция НГПТ
    

    mat_layer_Shopping_center,                 //Торговый центр
    mat_layer_Apartments,                      //Апартаменты
    mat_layer_Offices,                         //Офисы
    mat_layer_Residential_development,         //Жилая застойка

    mat_layer_Athletic_wellness_complex,       //Физкультурно - оздоровительный комплекс 
    mat_layer_AZS,                             //АЗС
    mat_layer_Entertaining_center,             //Развлекательно-досуговый центр
    mat_layer_Cinema,                          //Кинотеатр
    mat_layer_Showroom,                        //Выставочный зал
    mat_layer_Production_facility,             //Производственный объект
    mat_layer_Kindergarten,                    //Десткий сад
    mat_layer_School,                          //Школа
    mat_layer_Polyclinic,                      //Поликлиника
    mat_layer_Social_object,                   //Социальный объект
    mat_layer_subway,                          //Метрополитен


}
public enum LAYERS_Name
{
    Движение_автотранспорта,                      //Джидение автотранспорта
    Движение_пешеходов,               //Джидение пешеходов
    НГПТ,               //Джидение пешеходов
    Станция_ЖД,

    УДС,                              //УДС
    Терминал_пересадки,              //Терминал пересадки

    Административное_здание,          //Административное здание
    Подземный_пешеходный_переход,  //Подземный пешеходный переход
    Надземный_пешеходный_переход,     //Надземный пешеходный переход
    Пешеходный_навес,                //Пешеходный навес

    Перехватывающий_паркинг,             //Перехватывающий паркинг
    Парковки,                         //Парковка

    Отстойно_D_разворотная_площадка,              //Отстойно-разворотная площадка
    Остановка_НГПТ,                    //Остановка НГПТ
    Станция_НГПТ,                    //Станция НГПТ


    Торговый_центр,                 //Торговый центр
    Апартаменты,                      //Апартаменты
    Офисы,                         //Офисы
    Жилая_застойка,         //Жилая застойка

    Физкультурно_D_оздоровительный_комплекс,       //Физкультурно - оздоровительный комплекс 
    АЗС,                             //АЗС
    Развлекательно_D_досуговый_центр,             //Развлекательно-досуговый центр
    Кинотеатр,                          //Кинотеатр
    Выставочный_зал,                        //Выставочный зал
    Производственный_объект,             //Производственный объект
    Десткий_сад,                    //Десткий сад
    Школа,                          //Школа
    Поликлиника,                      //Поликлиника
    Социальный_объект,                   //Социальный объект
    Метрополитен                                    //Метрополитен 
}

public struct SettingLayer
{
    public static Dictionary<LAYERS_Name, string> LayerNames = new Dictionary<LAYERS_Name, string>()
    {
        {LAYERS_Name.Движение_автотранспорта, "mat_layer_Car_traffic"},
        {LAYERS_Name.Движение_пешеходов,"mat_layer_Pedestrian_traffic"},
        {LAYERS_Name.НГПТ,"mat_layer_NGPT_traffic"},

        {LAYERS_Name.УДС,"mat_layer_UDS"},
        {LAYERS_Name.Терминал_пересадки,"mat_layer_Transplant_Terminal"},
        {LAYERS_Name.Административное_здание,"mat_layer_Administrative_building"},
        {LAYERS_Name.Подземный_пешеходный_переход,"mat_layer_Underground_pedestrian_crossing"},
        {LAYERS_Name.Остановка_НГПТ,"mat_layer_Stopping_NGPT"},
        {LAYERS_Name.Пешеходный_навес,"mat_layer_Pedestrian_canopy"},
        {LAYERS_Name.Перехватывающий_паркинг,"mat_layer_Interceptive_parking"},
        {LAYERS_Name.Отстойно_D_разворотная_площадка,"mat_layer_Reversal_playground"},
        {LAYERS_Name.Надземный_пешеходный_переход,"mat_layer_Elevated_pedestrian_crossing"},
        {LAYERS_Name.Станция_НГПТ,"mat_layer_Station_NGPT"},
        {LAYERS_Name.Парковки,"mat_layer_Parking"},
        {LAYERS_Name.Торговый_центр,"mat_layer_Shopping_center"},
        {LAYERS_Name.Апартаменты,"mat_layer_Apartments"},
        {LAYERS_Name.Офисы,"mat_layer_Offices"},
        {LAYERS_Name.Жилая_застойка,"mat_layer_Residential_development"},
    
        {LAYERS_Name.Физкультурно_D_оздоровительный_комплекс,"mat_layer_Athletic_wellness_complex"},
        {LAYERS_Name.АЗС,"mat_layer_AZS"},
        {LAYERS_Name.Развлекательно_D_досуговый_центр,"mat_layer_Entertaining_center"},
        {LAYERS_Name.Кинотеатр,"mat_layer_Cinema"},
        {LAYERS_Name.Выставочный_зал,"mat_layer_Showroom"},
        {LAYERS_Name.Производственный_объект,"mat_layer_Production_facility"},
        {LAYERS_Name.Десткий_сад,"mat_layer_Kindergarten"},
        {LAYERS_Name.Школа,"mat_layer_School"},
        {LAYERS_Name.Поликлиника,"mat_layer_Polyclinic"},
        {LAYERS_Name.Социальный_объект,"mat_layer_Social_object"},

        {LAYERS_Name.Метрополитен,"mat_layer_subway"},
        {LAYERS_Name.Станция_ЖД ,"mat_layer_Railway_station"}
    };
    public static Dictionary<LAYERS_Mat, LAYERS_Name> LayerMat = new Dictionary<LAYERS_Mat, LAYERS_Name>()
    {
        {LAYERS_Mat.mat_layer_Car_traffic,LAYERS_Name.Движение_автотранспорта },
        {LAYERS_Mat.mat_layer_Pedestrian_traffic,LAYERS_Name.Движение_пешеходов},

        {LAYERS_Mat.mat_layer_UDS,LAYERS_Name.УДС},
        {LAYERS_Mat.mat_layer_Transplant_Terminal,LAYERS_Name.Терминал_пересадки},
        {LAYERS_Mat.mat_layer_Administrative_building,LAYERS_Name.Административное_здание},
        {LAYERS_Mat.mat_layer_Underground_pedestrian_crossing,LAYERS_Name.Подземный_пешеходный_переход},
        {LAYERS_Mat.mat_layer_Stopping_NGPT,LAYERS_Name.Остановка_НГПТ},
        {LAYERS_Mat.mat_layer_Pedestrian_canopy,LAYERS_Name.Пешеходный_навес},
        {LAYERS_Mat.mat_layer_Interceptive_parking,LAYERS_Name.Перехватывающий_паркинг},
        {LAYERS_Mat.mat_layer_Reversal_playground,LAYERS_Name.Отстойно_D_разворотная_площадка},
        {LAYERS_Mat.mat_layer_Elevated_pedestrian_crossing,LAYERS_Name.Надземный_пешеходный_переход},
        {LAYERS_Mat.mat_layer_Station_NGPT,LAYERS_Name.Станция_НГПТ},
        {LAYERS_Mat.mat_layer_Parking,LAYERS_Name.Парковки},
        {LAYERS_Mat.mat_layer_Shopping_center,LAYERS_Name.Торговый_центр},
        {LAYERS_Mat.mat_layer_Apartments,LAYERS_Name.Апартаменты},
        {LAYERS_Mat.mat_layer_Offices,LAYERS_Name.Офисы},
        {LAYERS_Mat.mat_layer_Residential_development,LAYERS_Name.Жилая_застойка},

        {LAYERS_Mat.mat_layer_Athletic_wellness_complex,LAYERS_Name.Физкультурно_D_оздоровительный_комплекс},
        {LAYERS_Mat.mat_layer_AZS,LAYERS_Name.АЗС},
        {LAYERS_Mat.mat_layer_Entertaining_center,LAYERS_Name.Развлекательно_D_досуговый_центр},
        {LAYERS_Mat.mat_layer_Cinema,LAYERS_Name.Кинотеатр},
        {LAYERS_Mat.mat_layer_Showroom,LAYERS_Name.Выставочный_зал},
        {LAYERS_Mat.mat_layer_Production_facility,LAYERS_Name.Производственный_объект},
        {LAYERS_Mat.mat_layer_Kindergarten,LAYERS_Name.Десткий_сад},
        {LAYERS_Mat.mat_layer_School,LAYERS_Name.Школа},
        {LAYERS_Mat.mat_layer_Polyclinic,LAYERS_Name.Поликлиника},
        {LAYERS_Mat.mat_layer_Social_object,LAYERS_Name.Социальный_объект},

        {LAYERS_Mat.mat_layer_subway,LAYERS_Name.Метрополитен},
        
    };

}

[System.Serializable]
public struct ScenObjectType
{
    public LAYERS_Name layerObject;
    public Category CategoryObject;

   
    //public MeshRenderer[] objectAsignMaterial;
    [Header("Пользовательское название слоя")]
    [TextArea(3, 5)]
    public string NameLayer;

    /*[HideInInspector]
    public Switch ThisSwith;*/
    [HideInInspector]
    public GameObject MeshShow;
    private Material mat;
    
    

     public void Inicialization()
    {
        if (NameLayer == String.Empty)
        {
            string nameLayer = layerObject.ToString();
            NameLayer = nameLayer.Replace("_", " ");

            if (NameLayer.Contains("D")) NameLayer = NameLayer.Replace("D", "-");
        }

        mat = Resources.Load<Material>(SettingLayer.LayerNames[layerObject]);
    }
}

public class ObjectSetup : MonoBehaviour
{
    [HideInInspector]
    public bool ExistPlaneLayer;
    public int OrderOfPriority;
    public ScenObjectType _scenObjectType;
    [HideInInspector]
    public MeshRenderer MeshRenderLayer;

    [Space]
    public MeshRenderer MeshRenderLayerPlane;
    public MeshRenderer MeshRenderLayerUndeground;

    [Space]
    private ManagerToggle ManagerToggle;

    public Color ColorLegend = Color.white; 

    public virtual void Awake()
    {
        ManagerToggle = FindObjectOfType<ManagerToggle>();
        _scenObjectType.MeshShow = gameObject;
        _scenObjectType.Inicialization();
        StartCoroutine(AddToManager());

        foreach (Transform tr in transform)
        {
            if (tr.name.Contains("_plane"))
            {
                
                MeshRenderLayerPlane = tr.GetComponent<MeshRenderer>();
                if (MeshRenderLayerPlane)
                {
                    MeshRenderLayerPlane.enabled = false;
                    ExistPlaneLayer = true;
                }
            }

            if (tr.name.Contains("_undeground"))
            {
                MeshRenderLayerUndeground = tr.GetComponent<MeshRenderer>();
                if (MeshRenderLayerUndeground) MeshRenderLayerUndeground.enabled = false;
            }
        }

        if (!MeshRenderLayer&&GetComponent<MeshRenderer>()) MeshRenderLayer = GetComponent<MeshRenderer>();
    }

    private IEnumerator AddToManager()
    {
        yield return new WaitForSeconds(OrderOfPriority <= 0
            ? (Time.deltaTime * transform.GetSiblingIndex() * 0.01f)
            : (OrderOfPriority * 0.01f));

        ManagerToggle.AddObject(this);
        _scenObjectType.MeshShow.SetActive(false);
    }
    

    public void ShowHideLayer()
    {
        
    }
    public void ChangeLayerViewType(bool isVoluneObject,bool isUndeground)
    {
        if (ExistPlaneLayer&& MeshRenderLayerPlane)
        {
            if (!MeshRenderLayerUndeground) MeshRenderLayerPlane.enabled = !isVoluneObject;

            if (MeshRenderLayerUndeground)
            {
                MeshRenderLayerPlane.enabled = !isUndeground & !isVoluneObject;
                MeshRenderLayerUndeground.enabled = isUndeground & !isVoluneObject;
            }
            //if (!isUndeground) MeshRenderLayerPlane.enabled = !isVoluneObject;
//             else
//             {
                //if(MeshRenderLayerUndeground) 
//            }

            MeshRenderLayer.enabled = isVoluneObject;
        }
    }
}
