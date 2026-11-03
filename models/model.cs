#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Altinn.App.Models.model
{
    [XmlRoot(ElementName = "model")]
    public class model
    {
        [XmlElement("arkivskaparVal", Order = 1)]
        [JsonProperty("arkivskaparVal")]
        [JsonPropertyName("arkivskaparVal")]
        public string? arkivskaparVal { get; set; }

        [XmlElement("arkivskaparNamn", Order = 2)]
        [JsonProperty("arkivskaparNamn")]
        [JsonPropertyName("arkivskaparNamn")]
        public string? arkivskaparNamn { get; set; }

        [XmlElement("eining", Order = 3)]
        [JsonProperty("eining")]
        [JsonPropertyName("eining")]
        public string? eining { get; set; }

        [XmlElement("roller", Order = 4)]
        [JsonProperty("roller")]
        [JsonPropertyName("roller")]
        public string? roller { get; set; }

        [XmlElement("foremaal", Order = 5)]
        [JsonProperty("foremaal")]
        [JsonPropertyName("foremaal")]
        public string? foremaal { get; set; }

        [XmlElement("hovudfunksjonar", Order = 6)]
        [JsonProperty("hovudfunksjonar")]
        [JsonPropertyName("hovudfunksjonar")]
        public string? hovudfunksjonar { get; set; }

        [XmlElement("arkivdelar", Order = 7)]
        [JsonProperty("arkivdelar")]
        [JsonPropertyName("arkivdelar")]
        public string? arkivdelar { get; set; }

        [XmlElement("datoForste", Order = 8)]
        [JsonProperty("datoForste")]
        [JsonPropertyName("datoForste")]
        public DateTime? datoForste { get; set; }

        [XmlElement("datoSiste", Order = 9)]
        [JsonProperty("datoSiste")]
        [JsonPropertyName("datoSiste")]
        public DateTime? datoSiste { get; set; }

        [XmlElement("periodeForre", Order = 10)]
        [JsonProperty("periodeForre")]
        [JsonPropertyName("periodeForre")]
        public string? periodeForre { get; set; }

        [XmlElement("periodeDenne", Order = 11)]
        [JsonProperty("periodeDenne")]
        [JsonPropertyName("periodeDenne")]
        public string? periodeDenne { get; set; }

        [XmlElement("systemtype", Order = 12)]
        [JsonProperty("systemtype")]
        [JsonPropertyName("systemtype")]
        public string? systemtype { get; set; }

        [XmlElement("noarkVersjon", Order = 13)]
        [JsonProperty("noarkVersjon")]
        [JsonPropertyName("noarkVersjon")]
        public string? noarkVersjon { get; set; }

        [XmlElement("noarkUnderversjon", Order = 14)]
        [JsonProperty("noarkUnderversjon")]
        [JsonPropertyName("noarkUnderversjon")]
        public string? noarkUnderversjon { get; set; }

        [XmlElement("arkivform", Order = 15)]
        [JsonProperty("arkivform")]
        [JsonPropertyName("arkivform")]
        public string? arkivform { get; set; }

        [XmlElement("tilknytteDokument", Order = 16)]
        [JsonProperty("tilknytteDokument")]
        [JsonPropertyName("tilknytteDokument")]
        public bool? tilknytteDokument { get; set; }

        [XmlElement("verksemdsspesifikke", Order = 17)]
        [JsonProperty("verksemdsspesifikke")]
        [JsonPropertyName("verksemdsspesifikke")]
        public bool? verksemdsspesifikke { get; set; }

        [XmlElement("verksemdsspesifikkeKommentar", Order = 18)]
        [JsonProperty("verksemdsspesifikkeKommentar")]
        [JsonPropertyName("verksemdsspesifikkeKommentar")]
        public string? verksemdsspesifikkeKommentar { get; set; }

        [XmlElement("datasystem", Order = 19)]
        [JsonProperty("datasystem")]
        [JsonPropertyName("datasystem")]
        public string? datasystem { get; set; }

        [XmlElement("databaseplattform", Order = 20)]
        [JsonProperty("databaseplattform")]
        [JsonPropertyName("databaseplattform")]
        public string? databaseplattform { get; set; }

        [XmlElement("uttrekksformat", Order = 21)]
        [JsonProperty("uttrekksformat")]
        [JsonPropertyName("uttrekksformat")]
        public string? uttrekksformat { get; set; }

        [XmlElement("uttrekksverktoy", Order = 22)]
        [JsonProperty("uttrekksverktoy")]
        [JsonPropertyName("uttrekksverktoy")]
        public string? uttrekksverktoy { get; set; }

        [XmlElement("antPostar", Order = 23)]
        [JsonProperty("antPostar")]
        [JsonPropertyName("antPostar")]
        public decimal? antPostar { get; set; }

        [XmlElement("antDokument", Order = 24)]
        [JsonProperty("antDokument")]
        [JsonPropertyName("antDokument")]
        public decimal? antDokument { get; set; }

        [XmlElement("systemdokumentasjon", Order = 25)]
        [JsonProperty("systemdokumentasjon")]
        [JsonPropertyName("systemdokumentasjon")]
        public bool? systemdokumentasjon { get; set; }

        [XmlElement("offentlegheit", Order = 26)]
        [JsonProperty("offentlegheit")]
        [JsonPropertyName("offentlegheit")]
        public string? offentlegheit { get; set; }

        [XmlElement("skjermingKommentar", Order = 27)]
        [JsonProperty("skjermingKommentar")]
        [JsonPropertyName("skjermingKommentar")]
        public string? skjermingKommentar { get; set; }

        [XmlElement("rettar", Order = 28)]
        [JsonProperty("rettar")]
        [JsonPropertyName("rettar")]
        public string? rettar { get; set; }

        [XmlElement("kommentar", Order = 29)]
        [JsonProperty("kommentar")]
        [JsonPropertyName("kommentar")]
        public string? kommentar { get; set; }

        [XmlElement("sjekksum", Order = 30)]
        [JsonProperty("sjekksum")]
        [JsonPropertyName("sjekksum")]
        public string? sjekksum { get; set; }

        [XmlElement("uuid", Order = 31)]
        [JsonProperty("uuid")]
        [JsonPropertyName("uuid")]
        public string? uuid { get; set; }

        [XmlElement("konvertering", Order = 32)]
        [JsonProperty("konvertering")]
        [JsonPropertyName("konvertering")]
        public string? konvertering { get; set; }

        [XmlElement("konvDato", Order = 33)]
        [JsonProperty("konvDato")]
        [JsonPropertyName("konvDato")]
        public DateTime? konvDato { get; set; }

        [XmlElement("konvUtfort", Order = 34)]
        [JsonProperty("konvUtfort")]
        [JsonPropertyName("konvUtfort")]
        public string? konvUtfort { get; set; }

        [XmlElement("konvFra", Order = 35)]
        [JsonProperty("konvFra")]
        [JsonPropertyName("konvFra")]
        public string? konvFra { get; set; }

        [XmlElement("konvKommentar", Order = 36)]
        [JsonProperty("konvKommentar")]
        [JsonPropertyName("konvKommentar")]
        public string? konvKommentar { get; set; }

        [XmlElement("kassasjon", Order = 37)]
        [JsonProperty("kassasjon")]
        [JsonPropertyName("kassasjon")]
        public string? kassasjon { get; set; }

        [XmlElement("kassDato", Order = 38)]
        [JsonProperty("kassDato")]
        [JsonPropertyName("kassDato")]
        public DateTime? kassDato { get; set; }

        [XmlElement("kassKva", Order = 39)]
        [JsonProperty("kassKva")]
        [JsonPropertyName("kassKva")]
        public string? kassKva { get; set; }

        [XmlElement("kassSeinare", Order = 40)]
        [JsonProperty("kassSeinare")]
        [JsonPropertyName("kassSeinare")]
        public bool? kassSeinare { get; set; }

        [XmlElement("kassSeinareKommentar", Order = 41)]
        [JsonProperty("kassSeinareKommentar")]
        [JsonPropertyName("kassSeinareKommentar")]
        public string? kassSeinareKommentar { get; set; }

        [XmlElement("kontaktNamn", Order = 42)]
        [JsonProperty("kontaktNamn")]
        [JsonPropertyName("kontaktNamn")]
        public string? kontaktNamn { get; set; }

        [XmlElement("kontaktRolle", Order = 43)]
        [JsonProperty("kontaktRolle")]
        [JsonPropertyName("kontaktRolle")]
        public string? kontaktRolle { get; set; }

        [XmlElement("kontaktEpost", Order = 44)]
        [JsonProperty("kontaktEpost")]
        [JsonPropertyName("kontaktEpost")]
        public string? kontaktEpost { get; set; }

        [XmlElement("kontaktTelefon", Order = 45)]
        [JsonProperty("kontaktTelefon")]
        [JsonPropertyName("kontaktTelefon")]
        public string? kontaktTelefon { get; set; }

        [XmlElement("stadfestProveniens", Order = 46)]
        [JsonProperty("stadfestProveniens")]
        [JsonPropertyName("stadfestProveniens")]
        public List<string>? stadfestProveniens { get; set; }

        [XmlElement("stadfestSletting", Order = 47)]
        [JsonProperty("stadfestSletting")]
        [JsonPropertyName("stadfestSletting")]
        public List<string>? stadfestSletting { get; set; }

    }
}
