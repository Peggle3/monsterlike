using Godot;
using System;

public partial class MonsterClass : Node
{
	public static int hp;
	public static int sp;
	public static int def;
	public static int spd;
	public static int str;
	public static int intel;
	public static int max_moves;
	public static string body_parts;
	
	public void setHp(int new_hp){
		hp = new_hp;
	}
}
