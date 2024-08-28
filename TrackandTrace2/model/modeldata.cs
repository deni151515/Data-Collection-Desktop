//Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System.Collections.Generic;

public class Box
{
    public string id { get; set; }
    public string name { get; set; }

    [JsonProperty("serial number")]
    public string boxserialnumber { get; set; }
    public List<Product> Product { get; set; }
}

public class Product
{
    [JsonProperty("batch No")]
    public string batchNo { get; set; }

    [JsonProperty("mfg.date")]
    public string mfgdate { get; set; }

    [JsonProperty("exp.date")]
    public string expdate { get; set; }
    public string status { get; set; }

    [JsonProperty("serial number")]
    public List<SerialNumber> serialnumber { get; set; }
}

public class Root
{
    public List<Warehouse> warehouses { get; set; }
}

public class SerialNumber
{
    [JsonProperty("serial number")]
    public string serialnumber { get; set; }
    [JsonProperty("serialbox")]

    public string serialbox { get; set; }
}

public class Warehouse
{
    public string id { get; set; }
    public string name { get; set; }
    public List<Box> Box { get; set; }
}
