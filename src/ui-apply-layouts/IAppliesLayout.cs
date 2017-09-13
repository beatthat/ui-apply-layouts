
namespace BeatThat
{
	/// <summary>
	/// Interface for components that apply a layout (e.g. sets rects, enables/disables components.)
	/// Exists to enable an editor function to recursively apply layout from a layout-controller parent object.
	/// </summary>
	public interface IAppliesLayout 
	{
		void ApplyLayout();
	}
}