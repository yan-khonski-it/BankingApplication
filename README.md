# Banking Application

I am learning .NET. I come from Java. : (

# Base project structure
## .gitignore file
[.gitignore file](https://github.com/yan-khonski-it/BankingApplication/blob/master/.gitignore)

I copied it from 
https://github.com/github/gitignore/blob/main/VisualStudio.gitignore

# C# basics
## Convert an object to JSON
Example (Accounts/Program.cs)[https://github.com/yan-khonski-it/BankingApplication/blob/master/Accounts/Program.cs]

1) Approach using class `System.Text.Json.JsonSerializer`.

```
var jsonSerializationOptions = new System.Text.Json.JsonSerializerOptions
{
    WriteIndented = true
};

string jsonString1 = System.Text.Json.JsonSerializer.Serialize<IAccount>(account1, jsonSerializationOptions);
```

This code prints
```
{
  "Balance": 900
}
```

This approach is recommended.

https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/migrate-from-newtonsoft?pivots=dotnet-7-0

However, if you have a base class and you do not know which super class is the current object is, you won't (de/) serialize it properly.

2) Deprecated, but still used approach with class `Newtonsoft.Json.JsonConvert`.

```
var jsonString2 = Newtonsoft.Json.JsonConvert.SerializeObject(account1, Newtonsoft.Json.Formatting.Indented);
Console.WriteLine(jsonString2);
```

This code prints
```
{
  "Owner": "John",
  "Balance": 900
}
```

https://www.reddit.com/r/csharp/comments/tnmgs4/newtonsoftjson_vs_systemtextjson_vs_jsonnet/

To use this library, add NuGet dependency into section `<ItemGroup>`
```
<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
```

[Accounts.csproj](https://github.com/yan-khonski-it/BankingApplication/blob/master/Accounts/Accounts.csproj)

## NuGet
