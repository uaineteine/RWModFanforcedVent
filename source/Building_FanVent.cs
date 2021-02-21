using System.Text;
using Verse;
using RimWorld;

namespace RimWorld
{
	public class Building_FanVent : Building_Vent
	{
		public override void TickRare()
		{
			if (FlickUtility.WantsToBeOn(this))
			{
				//def
				//GenTemperature.EqualizeTemperaturesThroughBuilding(this, 14f, twoWay: true);
				
				GenTemperature.EqualizeTemperaturesThroughBuilding(this, 20f, twoWay: true);
			}
		}
	}
}
