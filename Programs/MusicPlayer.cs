using System.Collections;
public class MusicPlayer
{
	private ArrayList sources;
	public MusicPlayer(params string[] s)
	{
		sources = new ArrayList ();
		foreach (string source in s) 
			add (source);
	}

	public void add(string source)
	{
		sources.Add (source);
	}
}
