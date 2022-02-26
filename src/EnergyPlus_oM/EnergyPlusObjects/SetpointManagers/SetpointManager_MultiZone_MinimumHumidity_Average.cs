using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager sets the average supply air minimum humidity ratio based on" +
                 " moisture load requirements of all controlled zones in an air loop served by a c" +
                 "entral air-conditioner.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_MultiZone_MinimumHumidity_Average : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of an AirLoopHVAC object")]
        [JsonProperty(PropertyName="hvac_air_loop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_setpoint_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointHumidityRatio { get; set; } = Double.Parse("0.005", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_setpoint_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointHumidityRatio { get; set; } = Double.Parse("0.012", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which the humidity ratio will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}