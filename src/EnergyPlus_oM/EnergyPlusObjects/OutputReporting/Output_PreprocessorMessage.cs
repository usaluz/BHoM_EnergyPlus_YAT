using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("This object does not come from a user input. This is generated by a pre-processor" +
                 " so that various conditions can be gracefully passed on by the InputProcessor.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_PreprocessorMessage : BHoMObject
    {
        

        [JsonProperty(PropertyName="preprocessor_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreprocessorName { get; set; } = "";
        

        [Description("Depending on type, InputProcessor may terminate the program.")]
        [JsonProperty(PropertyName="error_severity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_PreprocessorMessage_ErrorSeverity ErrorSeverity { get; set; } = (Output_PreprocessorMessage_ErrorSeverity)Enum.Parse(typeof(Output_PreprocessorMessage_ErrorSeverity), "Fatal");
        

        [JsonProperty(PropertyName="message_line_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine1 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine2 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine3 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine4 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine5 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine6 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine7 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine8 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine9 { get; set; } = "";
        

        [JsonProperty(PropertyName="message_line_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageLine10 { get; set; } = "";
    }
}