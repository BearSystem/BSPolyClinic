using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace BSPolyClinic.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EPhoneType
    {
        [Display(Name = "Residencial")]
        [Description("Telefone da casa")]
        Residential = 0,

        [Display(Name = "Pessoal")]
        [Description("Telefone pessoal")]
        Personal = 1,

        [Display(Name = "Amigos")]
        [Description("Telefone de amigos")]
        Friends = 2,

        [Display(Name = "Familia")]
        [Description("Telefone de familiares")]
        Family = 3,

        [Display(Name = "Trabalho")]
        [Description("Telefone do trabalho")]
        Work = 4,
    }
}
