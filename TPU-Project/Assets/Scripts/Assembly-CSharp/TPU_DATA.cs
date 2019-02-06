using System;

[Serializable]
public struct TPU_DATA
{
	public bool success;
	public string msg;
	public Data[] data;
	public Filters filters;
}
