using System.Diagnostics;

internal class Program
{
	private static void Main(string[] args)
	{
		// Replace 1st argument with pathway to ModOrganizer.
		Process.Start(@"B:\Games\Wabbajack\modlists\eldergleam\ModOrganizer.exe", @"moshortcut://:SKSE");
	}
}