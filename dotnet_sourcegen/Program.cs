using dotnet_sourcegen;
using System.Reflection;
using System.Text;
using testlib;

/*
var type = typeof(Class1);
var t2 = Type.GetType("testlib.Class1,testlib");
var properties = type?.GetProperties(BindingFlags.Instance | BindingFlags.Public);

foreach (var property in properties)
{
    Console.WriteLine(property.PropertyType.Name);
    Console.WriteLine(property.Name);
}
*/

var classes = new string[] {
    "testlib.Class1,testlib",
    "testlib.Class2,testlib"
};

foreach(var className in classes)
{
    var type = Type.GetType(className);

    var path = $"{type!.Name}.cs"!;

    var template = new RuntimeTextTemplate1(type!);
    var text = template.TransformText();
    using (var sw = new StreamWriter(path!, true, Encoding.UTF8))
    {
        sw.Write(text);
    }
}

