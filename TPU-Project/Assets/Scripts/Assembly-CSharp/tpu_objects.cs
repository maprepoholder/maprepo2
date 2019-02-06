using System;

[Serializable]
public struct tpu_objects
{
	public int id;
	public int tpu_id;
	public int stage;
	public string type;
	public string category;
	public int scheme_n;
	public string obj_name;
	public int flore_sum_sq;
	public int obj_sq_onground;
	public int obj_sq_underground;
	public int ploskost_obj;
	public string pir_start;
	public string pir_end;
	public string smr_start;
	public string smr_end;
	public int building_cost;
	public int revenue;
	public int profit;
	public int source_cost;
	public string source_name;
}
