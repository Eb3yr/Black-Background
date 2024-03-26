namespace BlackBack
{
	public partial class Form1 : Form
	{
		public Form1(Config conf)
		{
			Rectangle bounds = new Rectangle(0, 0, conf.width, conf.height);
			int screen = conf.screen;
			InitializeComponent(bounds, screen);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
