using System.Runtime.Serialization;

[DataContract()]
public　class testTable {

	[DataMember]
	public int test_id { get; set; }

	[DataMember]
	public string name { get; set; }
}