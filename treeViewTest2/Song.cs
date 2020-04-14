using System;

public class Song {

    public int artist_id { get; set; }
    public string Artist { get; set; }
    public string Title { get; set; }

    private bool _Del = false;
    public bool Del {
		get {
			return _Del;
		}
		set {
			_Del = value;
		}
    }

	private bool _Effective = true;
	public bool Effective {
		get {
			return _Effective;
		}
		set {
			_Effective = value;
		}
	}
}


