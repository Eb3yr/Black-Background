using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlackBack
{
	public class Config
	{
		[JsonRequired]
		public int width { get; set; }
		[JsonRequired]
		public int height { get; set; }
		[JsonRequired]
		public int screen {  get; set; }
	}
	internal static class Program
	{
		
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Config conf = new Config
			{
				width = Screen.PrimaryScreen.Bounds.X,
				height = Screen.PrimaryScreen.Bounds.Y,
				screen = 0
			};
			bool retry = false;
			if(File.Exists("config.json"))
			{
				try
				{
					conf = LoadConfig();
				}
				catch (Exception) // malformed config
				{
					retry = true;
					GenerateConfig(conf);
				}
			}
			else // no config found
			{
				retry = true;
				GenerateConfig(conf);
			}

			if (retry)
			{
				conf = LoadConfig();
			}

			Application.Run(new Form1(conf));
			
		}
		static void GenerateConfig(Config conf)
		{
			File.WriteAllText("config.json", JsonSerializer.Serialize(conf));
		}
		static Config LoadConfig()
		{
			return JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
		}
	}
}