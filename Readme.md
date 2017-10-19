Messing about with signalr. Just for myself, here are some notes....carry on!

```sh
dotnet new mvc --name SignalRYo --auth None
dotnet add package Microsoft.AspNetCore.SignalR --version 1.0.0-alpha1-final
npm init
npm install --save @aspnet/signalr-client

```

add to csproj

```xml

  <Target Name="CopyFiles" BeforeTargets="Publish">
    <Exec Command="npm install" />
    <ItemGroup>
      <NpmFiles Include=".\node_modules\@aspnet\signalr-client\dist\browser\*.js" />
    </ItemGroup>
    <Copy SourceFiles="@(NpmFiles)" DestinationFolder="wwwroot\js\signalr" />
  </Target>

```

Created Chat.cs, added some js to the home page