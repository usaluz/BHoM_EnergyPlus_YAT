using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("used for shading elements such as trees, other buildings, parts of this building " +
                 "not being modeled these items are relative to the current building and would mov" +
                 "e with relative geometry")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Shading_Building_Detailed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Transmittance schedule for the shading device, defaults to zero (always opaque)")]
        [JsonProperty(PropertyName="transmittance_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransmittanceScheduleName { get; set; } = "";
        

        [Description("shown with 6 vertex coordinates -- extensible object Rules for vertices are given" +
                     " in GlobalGeometryRules coordinates -- For this object all surface coordinates a" +
                     "re relative to the building origin (0,0,0) and will rotate with the BUILDING nor" +
                     "th axis.")]
        [JsonProperty(PropertyName="number_of_vertices", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> NumberOfVertices { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="vertices", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building_Detailed_Vertices_Item> Vertices { get; set; } = null;
    }
}