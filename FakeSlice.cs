using Lenovo.Modern.Portable.Battery;
using Native;
using System;

namespace ThinkBattery
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var batInterface = new BatteryInterface();
            var chargeStatus = batInterface.QueryBattery(1).SmartBatteryStatus.ChargeStatus.GetValue();
            var chargeStatusTwo = batInterface.QueryBattery(2).SmartBatteryStatus.ChargeStatus.GetValue();
            var bat = new ChargeThreshold {
                IsEnabled = true,
                SlotNumber = 1,
                StartValue = 0,
                StopValue = 0
            };
            if (chargeStatus == "Charging" || chargeStatusTwo == "Charging") {
                bat.StopValue = 1;
            }
            if (args.Length == 1 && args[0] == "on") {
                bat.StopValue = 1;
            } else if (args.Length == 1 && args[0] == "off") {
                bat.StopValue = 0;
            }
            batInterface.SetChargeThreshold(bat);
            bat.SlotNumber = 2;
            batInterface.SetChargeThreshold(bat);
        }
    }
}