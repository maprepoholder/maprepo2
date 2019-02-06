using System;

[Serializable]
public struct Filters
{
	public string pir_start;
	public string pir_end;
	public string smr_start;
	public string smr_end;
	public PPT_approve[] ppt_approve;
	public Pablic_hearings[] pablic_hearings;
	public PPM_approvep[] ppm_approve;
	public Formalization[] formalization;
	public Realization[] realization;
	public TPU_objects_type[] tpu_objects_type;
}
