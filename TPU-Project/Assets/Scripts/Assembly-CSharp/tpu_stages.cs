using System;

[Serializable]
public struct tpu_stages
{
	public int id;
	public int tpu_id;
	public string engineering_start;
	public string engineering_end;
	public string construction_end;
	public string formalization;
	public string realization;
	public int position;
	public types[] types;
}
