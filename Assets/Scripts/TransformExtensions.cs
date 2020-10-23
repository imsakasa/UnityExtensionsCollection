using UnityEngine;

public static class TransformExtentions
{
	#region Position
	public static void SetPosition(this Transform transform, float x, float y, float z)
	{
		var pos = new Vector3(x, y, z);
		transform.position = pos;
	}

	public static void SetPosX(this Transform transform, float x)
	{
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}

	public static void SetPosY(this Transform transform, float y)
	{
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}

	public static void SetPosZ(this Transform transform, float z)
	{
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	}

	public static void AddPosition(this Transform transform, float x, float y, float z)
	{
		transform.position = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z);
	}

	public static void AddPosX(this Transform transform, float x)
	{
		transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);
	}

	public static void AddPosY(this Transform transform, float y)
	{
		transform.position = new Vector3(transform.position.x, transform.position.y + y, transform.position.z);
	}

	public static void AddPosZ(this Transform transform, float z)
	{
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + z);
	}
	#endregion

	#region LocalPosition
	public static void SetLocalPosition(this Transform transform, float x, float y, float z)
	{
		var pos = new Vector3(x, y, z);
		transform.localPosition = pos;
	}
	public static void SetLocalPosX(this Transform transform, float x)
	{
		transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
	}

	public static void SetLocalPosY(this Transform transform, float y)
	{
		transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
	}

	public static void SetLocalPosZ(this Transform transform, float z)
	{
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
	}

	public static void AddLocalPosition(this Transform transform, float x, float y, float z)
	{
		transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z + z);
	}

	public static void AddLocalPosX(this Transform transform, float x)
	{
		transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z);
	}

	public static void AddLocalPosY(this Transform transform, float y)
	{
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + y, transform.localPosition.z);
	}

	public static void AddLocalPosZ(this Transform transform, float z)
	{
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + z);
	}
	#endregion
}