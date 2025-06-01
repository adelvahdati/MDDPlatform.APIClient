using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MDDPlatform.APIClient;
using MDDPlatform.APIClient.Services.Concepts;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using MDDPlatform.APIClient.Services.Languages;
using MDDPlatform.APIClient.Services.ProblemDomains;
using MDDPlatform.APIClient.Services.Domains;
using MDDPlatform.APIClient.Services.DomainModels;
using MDDPlatform.APIClient.Services.DomainConcepts;
using MDDPlatform.APIClient.Services.Patterns;
using MDDPlatform.APIClient.Services.Transformations;
using MDDPlatform.APIClient.Services.Pipelines;
using MDDPlatform.APIClient.Services.Scripts;
using MDDPlatform.APIClient.Services.PatternInstanceTemplates;
using MDDPlatform.APIClient.Services.Processes;
using MDDPlatform.APIClient.Services.PlantUMLs;
using MDDPlatform.APIClient.Services.ProcessConfigurations;
using MDDPlatform.APIClient.Services.ExecutableProcesses;
using MDDPlatform.APIClient.Services.ProjectFileServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add Blazorize
builder.Services
    .AddBlazorise( options =>
    {
        options.Immediate = true;
    } )
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();




builder.Services.AddHttpClient<IConceptService,ConceptService>(httpClient=>
{
    var url = builder.Configuration["Services:ConceptService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<ILanguageService,LanguageService>(httpClient=>
{
    var url = builder.Configuration["Services:ConceptService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IProblemDomainService,ProblemDomainService>(httpClient=>
{
    var url = builder.Configuration["Services:ProblemDomainService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IDomainService,DomainService>(httpClient=>
{
    var url = builder.Configuration["Services:DomainService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IPackageService,PackageService>(httpClient=>
{
    var url = builder.Configuration["Services:DomainService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IDomainModelService,DomainModelService>(httpClient=>
{
    var url = builder.Configuration["Services:DomainModelService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IDomainConceptService,DomainConceptService>(httpClient=>{
    var url = builder.Configuration["Services:DomainModelService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IPatternService,PatternService>(httpClient=>
{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IPatternInstanceTemplateService,PatternInstanceTemplateService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});

builder.Services.AddHttpClient<ITransformationService,TransformationService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IPipelineService,PipelineService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});

builder.Services.AddHttpClient<IScriptManagementService,ScriptManagementService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});

builder.Services.AddHttpClient<IProcessService,ProcessService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});
builder.Services.AddHttpClient<IProcessConfigurationService,ProcessConfigurationService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});

builder.Services.AddHttpClient<IExecutableProcessService,ExecutableProcessService>(httpClient=>{
    var url = builder.Configuration["Services:TransformationService"];
    httpClient.BaseAddress = new Uri(url);
});

builder.Services.AddHttpClient<IPlantUMLService,PlantUMLService>(httpClient=>{
    var url = builder.Configuration["Services:DiagramService"];
    httpClient.BaseAddress = new Uri(url);
});

builder.Services.AddSingleton<IProjectFileService,ProjectFileService>();

await builder.Build().RunAsync();
