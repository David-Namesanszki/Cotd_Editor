using System.Text.Json.Serialization;

namespace Cotd_Editor.Models.Captains;

public class CaptainModel
{
	public string Image { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public int Health { get; set; } = 0;
	public int Power { get; set; } = 0;
	public int Armor { get; set; } = 0;
}
