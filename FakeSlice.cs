using Lenovo.Modern.Portable.Battery;
using Native;

namespace ThinkBattery
{
	class Program
	{
		static void Main(string[] args)
		{
			var batInterface = new BatteryInterface();
			var chargeStatus = batInterface.QueryBattery(1).SmartBatteryStatus.ChargeStatus.GetValue();
			var chargeStatusTwo = batInterface.QueryBattery(2).SmartBatteryStatus.ChargeStatus.GetValue();
			var notification = new System.Windows.Forms.NotifyIcon()
			{
				Visible = true,
				Icon = System.Drawing.SystemIcons.Information,
				BalloonTipTitle = "FakeSlice",
			   	BalloonTipText = "Charging battery."
			};
			var bat = new ChargeThreshold {
				IsEnabled = true,
				SlotNumber = 1,
				StartValue = 0,
				StopValue = 0
			};	  
			if ((chargeStatus == "Charging" || chargeStatusTwo == "Charging") && (args.Length == 0 || (args.Length == 1 && args[0] != "off"))) {
			   	bat.StopValue = 1;
			   	notification.BalloonTipText = "Running on external power.";
			}
			batInterface.SetChargeThreshold(bat);
			bat.SlotNumber = 2;
			batInterface.SetChargeThreshold(bat);
			notification.ShowBalloonTip(1000);
			notification.Dispose();
		}
	}
}
