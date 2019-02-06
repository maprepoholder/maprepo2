using System;

[Serializable]
public struct Data
{
	public int id;
	public string title;
	public string date;
	public string tpu_key;
	public int tpu_id;
	public float ppt_area;
	public float tpu_area;
	public string tpu_type;
	public string location_name;
	public string traffic_load;
	public int parking_need;
	public string parking_comment;
	public string approve_area_tpu_objects_rggzk;
	public string approve_area_tpu_objects_gzk;
	public string project_dev_territory_planning_rggzk;
	public string project_dev_territory_planning_gzk;
	public string pablic_hearings;
	public string ppm_approve;
	public string tpu_description;
	public string subway_station;
	public string obremen_img;
	public string genplan_img;
	public float lat;
	public float lon;
	public Obremen_zu[] obremen_zu;
	public tpu_stages[] tpu_stages;
	public int technology_sum;
	public int commercial_sum;
	public tranport_types[] tranport_types;
	public Film film;
	public Gallery[] gallery;
}
