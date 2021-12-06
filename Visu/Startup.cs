using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mitoSoft.Common.Mqtt;
using mitoSoft.Razor.homeNet.Components.EventArgs;
using mitoSoft.Razor.homeNet.Components.Models;
using mitoSoft.Razor.homeNet.TimerComponents.Clients;
using mitoSoft.Razor.homeNet.TimerComponents.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Visu
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ComponentList Components { get; private set; }

        public MqttClient MqttClient { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<FlowClient>();
            services.AddSingleton<DailyTimerClient>();
            services.AddSingleton<ClientHelper>();

            Components = new ComponentList(new ComponentLoader());
            Components.ComponentClicked += Components_ComponentClicked;
            services.AddSingleton<ComponentList>(Components);

            MqttClient = new MqttClient(Configuration["MqttHostIP"])
            {
                Topics = RegisterTopics().ToList()
            };
            MqttClient.MessageReceived += OnMqttMessageReceived;
            MqttClient.Connect("BlazorVisu" + System.Guid.NewGuid().ToString());
            services.AddSingleton<MqttClient>(MqttClient);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        private IList<string> RegisterTopics()
        {
            var topics = Configuration.GetSection("MqttTopics").Get<List<string>>();
            return topics;
        }

        private void OnMqttMessageReceived(mitoSoft.Common.Mqtt.MqttMessage mqttMessage)
        {
            Components.MessageReceived(mqttMessage.Topic, mqttMessage.Message);
        }

        private void Components_ComponentClicked(ComponentClickedEventArgs e)
        {
            MqttClient.Publish(e.MqttMessage.Topic, e.MqttMessage.Message, 2, false);
        }
    }
}
