using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal generic contaminant gains and sinks in a zone with constant values." +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneContaminantSourceAndSink_Generic_Constant : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("The values represent source.")]
        [JsonProperty(PropertyName="design_generation_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignGenerationRate { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design Generation Rate")]
        [JsonProperty(PropertyName="generation_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GenerationScheduleName { get; set; } = "";
        

        [Description("The value represent sink.")]
        [JsonProperty(PropertyName="design_removal_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignRemovalCoefficient { get; set; } = null;
        

        [Description("Value in this schedule should be a fraction (generally 0.0 - 1.0) applied to the " +
                     "Design removal Coefficient")]
        [JsonProperty(PropertyName="removal_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RemovalScheduleName { get; set; } = "";
    }
}