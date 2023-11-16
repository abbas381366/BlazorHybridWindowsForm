using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;


namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        StateManager stateManager = new StateManager();
        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddSingleton<StateManager>(stateManager);
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.RootComponents.Add<Couter>("#app");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stateManager.Counter++;
            stateManager.StateChanged();
        }
    }
}
