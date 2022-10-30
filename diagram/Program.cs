using System.Xml.Schema;
using System.Xml.Serialization;
using animal;

Console.WriteLine("\nAnimal");
var anim = typeof(Animal);
foreach (var member in anim.GetMembers())
{
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
}
foreach (var i in anim.GetCustomAttributes(false))
{
    Console.WriteLine(i);
}

Console.WriteLine("\nCow");
var cow = typeof(Cow);
foreach (var member in cow.GetMembers())
{
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
}
foreach (var i in cow.GetCustomAttributes(false))
{
    Console.WriteLine(i);
}


foreach (var i in new []{"eFavoriteFood", "Animal"})
{
    break;
}
var schema = new XmlSchemas();
var exporter = new XmlSchemaExporter(schema);
var mapping = new XmlReflectionImporter().ImportTypeMapping(typeof(Animal));
exporter.ExportTypeMapping(mapping);
var schemaWriter = new StringWriter();
foreach (XmlSchema schem in schema)
{
    schem.Write(schemaWriter);
}
await using (var file = new StreamWriter("Animal.xml", false))
{
    await file.WriteLineAsync(schemaWriter.ToString());
}
schema.Clear();
exporter = new XmlSchemaExporter(schema);
mapping = new XmlReflectionImporter().ImportTypeMapping(typeof(Lion));
exporter.ExportTypeMapping(mapping);
schemaWriter = new StringWriter();
foreach (XmlSchema schem in schema)
{
    schem.Write(schemaWriter);
}
Console.WriteLine(schemaWriter.ToString());
await using (var file = new StreamWriter("Lion.xml", false))
{
    await file.WriteLineAsync(schemaWriter.ToString());
}

