using Godot;
using System;

public partial class Box : MeshInstance3D
{
	public override void _Ready()
	{
		GD.Print("Test");
	}

	public override void _Process(double delta)
	{
		Rotate(Vector3.Up, 1);
	}
}
