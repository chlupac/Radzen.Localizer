// See https://aka.ms/new-console-template for more information

using System.Reflection;
using Radzen;

Assembly rb = typeof(RadzenComponent).Assembly;
foreach (Type type in rb.GetTypes().Where(x=>x.IsSubclassOf(typeof(RadzenComponent)) && x.GetProperties().Any(p=>p.Name.EndsWith("Text")&& p.Name!="Text")))
{
    var name = type.Name.Replace("`1", "");
    if (type.IsGenericType)
    {
        
        var param = type.GetGenericArguments()[0].Name;

        var classHeader = $"public class {name}Localized<{param}> : {name}<{param}>";
        
        Console.WriteLine(classHeader);
    }
    else
    {
        var classHeader = $"public class {name}Localized : {name}";
        
        Console.WriteLine(classHeader);
    }
    Console.WriteLine(                          $"{{\n" +
                                                $"    [Inject] RadzenLocalizer L {{ get; set; }}\n" +
                                                $"    protected override void OnInitialized()\n" +
                                                $"    {{"
        );
    foreach (var property in type.GetProperties().Where(p=>p.Name.EndsWith("Text") && p.Name!="Text"))
    {
        Console.WriteLine($"      {property.Name} = L[\"{name}.{property.Name}\"] ?? {property.Name};");
    }
    
    Console.WriteLine("        base.OnInitialized();\n    }\n}\n");
}

foreach (Type type in rb.GetTypes().Where(x=>x.IsSubclassOf(typeof(RadzenComponent)) && x.GetProperties().Any(p=>p.Name.EndsWith("Text")&& p.Name!="Text")))
{
    var name = type.Name.Replace("`1", "");
    foreach (var property in type.GetProperties().Where(p=>p.Name.EndsWith("Text") && p.Name!="Text"))
    {
        Console.WriteLine($"    <data name=\"{name}.{property.Name}\" xml:space=\"preserve\">\n    <value>{name}.{property.Name}</value>\n  </data>");
    }
}

foreach (Type type in rb.GetTypes().Where(x=>x.IsSubclassOf(typeof(RadzenComponent)) && x.GetProperties().Any(p=>p.Name.EndsWith("Text")&& p.Name!="Text")))
{
    var name = type.Name.Replace("`1", "");
    var p = type.IsGenericType ? "<>" : "";
    Console.WriteLine($"componentActivator.RegisterOverride(typeof({name}{p}), typeof({name}Localized{p}));");
}

Console.ReadLine();
